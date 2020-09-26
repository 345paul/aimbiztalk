﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AzureIntegrationMigration.BizTalk.Convert;
using Microsoft.AzureIntegrationMigration.BizTalk.StageRunners.Resources;
using Microsoft.AzureIntegrationMigration.BizTalk.Types;
using Microsoft.AzureIntegrationMigration.BizTalk.Types.Entities;
using Microsoft.AzureIntegrationMigration.Runner.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Microsoft.AzureIntegrationMigration.BizTalk.StageRunners.Convert
{
    /// <summary>
    /// Stage runner for generating the target artifacts in the target model.
    /// </summary>
    public class ArtifactGeneratorConverter : StageRunnerBase, IStageConverter
    {
        /// <summary>
        /// Defines the name of this stage runner.
        /// </summary>
        public const string PluginName = ModelConstants.ApplicationPrefix + "artifactgenerator";

        /// <summary>
        /// Defines an argument name representing the conversion path.
        /// </summary>
        public const string ArgConversionPath = "microsoft.core.conversionpath";

        /// <summary>
        /// Defines an argument name representing the generation path.
        /// </summary>
        public const string ArgGenerationPath = "microsoft.core.generationpath";

        /// <summary>
        /// Defines an argument name representing the template paths.
        /// </summary>
        public const string ArgTemplatePaths = "microsoft.core.templatepaths";

        /// <summary>
        /// Defines the path for templates that are generated by rules, rather than pre-built in
        /// template directories.
        /// </summary>
        public const string DefaultGenerationPath = "generated";

        /// <summary>
        /// Defines a logger.
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Defines a list of directory containing template config files.
        /// </summary>
        private readonly List<string> _templatePaths = new List<string>();

        /// <summary>
        /// Defines a directory to store converted output.
        /// </summary>
        private string _conversionPath;

        /// <summary>
        /// Defines a directory to store generated output.
        /// </summary>
        private string _generationPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactGeneratorConverter"/> class with a generic logger.
        /// </summary>
        /// <param name="logger">A logger.</param>
        public ArtifactGeneratorConverter(ILogger logger)
            : base(PluginName, Stages.Convert, 10, logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Runs the stage runner.
        /// </summary>
        /// <param name="state">The execution state.</param>
        /// <param name="token">A cancellation token used to cancel this operation.</param>
        /// <returns>A task used to await the operation.</returns>
        protected override async Task InvokeRunAsync(IRunState state, CancellationToken token)
        {
            _ = state ?? throw new ArgumentNullException(nameof(state));

            // Default conversion directory if not specified
            if (string.IsNullOrWhiteSpace(_conversionPath))
            {
                _conversionPath = Environment.CurrentDirectory;
            }

            // Default generation directory if not specified
            if (string.IsNullOrWhiteSpace(_generationPath))
            {
                _generationPath = Path.Combine(_conversionPath, DefaultGenerationPath);
            }

            // Get context
            var context = Container.GetRequiredService<MigrationContext>();
            context.ConversionFolder = _conversionPath;
            context.GenerationFolder = _generationPath;
            _templatePaths.Add(_generationPath);
            _templatePaths.ForEach(p => context.TemplateFolders.Add(p));

            // Get artifact generators
            var generators = new BizTalkConverterBase[]
            {
                Container.GetRequiredService<BizTalk.Convert.GeneratorRules.AP001ReceiveRoutingSlipGenerator>(),
                Container.GetRequiredService<BizTalk.Convert.GeneratorRules.AP002SendRoutingSlipGenerator>(),
                Container.GetRequiredService<BizTalk.Convert.GeneratorRules.AP003ReceiveConfigurationEntryGenerator>(),
                Container.GetRequiredService<BizTalk.Convert.GeneratorRules.AP004SendConfigurationEntryGenerator>(),
                Container.GetRequiredService<BizTalk.Convert.GeneratorRules.AP005SendRoutingPropertyGenerator>(),
                Container.GetRequiredService<BizTalk.Convert.GeneratorRules.AP006ReceiveRoutingPropertyGenerator>(),
                Container.GetRequiredService<BizTalk.Convert.GeneratorRules.SC001DocumentSchemaGenerator>(),
                Container.GetRequiredService<BizTalk.Convert.GeneratorRules.SC002PropertySchemaGenerator>(),
                Container.GetRequiredService<BizTalk.Convert.GeneratorRules.MA001TransformGenerator>(),
                Container.GetRequiredService<BizTalk.Convert.GeneratorRules.WF001WorkflowGenerator>(),
                Container.GetRequiredService<BizTalk.Convert.GeneratorRules.AP007ProcessManagerRoutingSlipGenerator>(),
                Container.GetRequiredService<BizTalk.Convert.GeneratorRules.AP008ProcessManagerConfigurationEntryGenerator>()
            };

            _logger.LogTrace(TraceMessages.RunningArtifactGeneratorConverter, generators.Length);

            // Generate converters
            foreach (var analyzer in generators)
            {
                await analyzer.ConvertAsync(token).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Gets arguments for this stage runner.
        /// </summary>
        protected override void GetArgs()
        {
            // Conversion Directory
            var argConversionDir = GetArg<string>(ArgConversionPath);
            if (!string.IsNullOrWhiteSpace(argConversionDir))
            {
                _logger.LogInformation(InformationMessages.ArgumentsFound, ArgConversionPath, argConversionDir);

                _conversionPath = new DirectoryInfo(argConversionDir).FullName;
            }

            // Generation Directory
            var argGenerationDir = GetArg<string>(ArgGenerationPath);
            if (!string.IsNullOrWhiteSpace(argGenerationDir))
            {
                _logger.LogInformation(InformationMessages.ArgumentsFound, ArgGenerationPath, argGenerationDir);

                _generationPath = new DirectoryInfo(argGenerationDir).FullName;
            }

            // Template Directories
            var argValue = GetArg(ArgTemplatePaths);
            if (argValue != null)
            {
                _logger.LogInformation(InformationMessages.ArgumentsFound, ArgTemplatePaths, argValue);

                // Should be an array of directories
                foreach (var dir in (string[])argValue)
                {
                    _templatePaths.Add(dir);
                }
            }
        }

        /// <summary>
        /// Validates the arguments found on the command line.
        /// </summary>
        protected override bool ValidateArgs()
        {
            var valid = true;

            // Template Directories
            _templatePaths.ForEach(p =>
            {
                var dirInfo = new DirectoryInfo(p);
                if (!dirInfo.Exists)
                {
                    _logger.LogError(ErrorMessages.TemplateDirectoryDoesNotExist, dirInfo.FullName);
                    valid = false;
                }
            });

            return valid;
        }
    }
}
