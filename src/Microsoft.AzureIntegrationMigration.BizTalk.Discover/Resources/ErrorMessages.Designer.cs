// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AzureIntegrationMigration.BizTalk.Discover.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AzureIntegrationMigration.BizTalk.Discover.Resources.ErrorMessages", typeof(ErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find an application definition file in the supplied BizTalk MSI file &apos;{0}&apos;. Unable to continue without a application definition file..
        /// </summary>
        internal static string ApplicationDefinitionNotFoundInMsi {
            get {
                return ResourceManager.GetString("ApplicationDefinitionNotFoundInMsi", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find a binding file called &apos;{0}&apos; in the supplied BizTalk MSI file &apos;{1}&apos;. Unable to continue without a binding file..
        /// </summary>
        internal static string BindingFileNotFoundInMSI {
            get {
                return ResourceManager.GetString("BindingFileNotFoundInMSI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The MSI file &apos;{0}&apos; was not found..
        /// </summary>
        internal static string ErrorMsiNotFound {
            get {
                return ResourceManager.GetString("ErrorMsiNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error opening application definition file &apos;{0}&apos;.  Details:\n{1}.
        /// </summary>
        internal static string ErrorOpeningApplicationDefinitionFile {
            get {
                return ResourceManager.GetString("ErrorOpeningApplicationDefinitionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred trying to parse the MSI file {0}. The error was: {1}..
        /// </summary>
        internal static string ErrorParsingMSIFile {
            get {
                return ResourceManager.GetString("ErrorParsingMSIFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred trying to parse the MSI file {0}. The error was: No files found in the MSI file..
        /// </summary>
        internal static string ErrorParsingMSIFileNoFiles {
            get {
                return ResourceManager.GetString("ErrorParsingMSIFileNoFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred trying to process the files within the MSI file {0}. The error was: {1}..
        /// </summary>
        internal static string ErrorProcessingMSIFile {
            get {
                return ResourceManager.GetString("ErrorProcessingMSIFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred whilst reading BizTalk Assemblies, in the directory &apos;{0}&apos;. Unable to continue.: Details:\n{1}.
        /// </summary>
        internal static string FailureWhenReadingBizTalkAssemblies {
            get {
                return ResourceManager.GetString("FailureWhenReadingBizTalkAssemblies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to load a {0} with type {1} because the assembly referenced in binding file is not included in list of assemblies supplied. Expected to find assembly called: {2}..
        /// </summary>
        internal static string FindResourceAssemblyError {
            get {
                return ResourceManager.GetString("FindResourceAssemblyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to load a {0} with type {2} from assembly {3} as unable to find a field called {1} in this type. Check that this is a BizTalk-created {0}..
        /// </summary>
        internal static string GetResourcePrivateFieldError {
            get {
                return ResourceManager.GetString("GetResourcePrivateFieldError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to load type details from a supplied {0} node. Node inner text is: {1}..
        /// </summary>
        internal static string GetResourceTypeDetailsError {
            get {
                return ResourceManager.GetString("GetResourceTypeDetailsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} handler encountered an error trying to analyze a {1} resource: {2}.
        /// </summary>
        internal static string HandlerAnalysisError {
            get {
                return ResourceManager.GetString("HandlerAnalysisError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} handler is unable to support resources of type {1}..
        /// </summary>
        internal static string HandlerUnsupportedResourceType {
            get {
                return ResourceManager.GetString("HandlerUnsupportedResourceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find an attribute called &apos;FullName&apos; on the supplied transform node in the binding file..
        /// </summary>
        internal static string NoFullNameAttributeOnTransformNode {
            get {
                return ResourceManager.GetString("NoFullNameAttributeOnTransformNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find a Transform entity in the current parsed BizTalkApplication with a full name of: {0}..
        /// </summary>
        internal static string NoTransformFoundWithGivenName {
            get {
                return ResourceManager.GetString("NoTransformFoundWithGivenName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.
        /// </summary>
        internal static string ParsingError {
            get {
                return ResourceManager.GetString("ParsingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find a handler for this resource: {0}.
        /// </summary>
        internal static string ParsingErrorNoHandlerFound {
            get {
                return ResourceManager.GetString("ParsingErrorNoHandlerFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to deserialize pipeline: {0}.
        /// </summary>
        internal static string PipelineDeserializationError {
            get {
                return ResourceManager.GetString("PipelineDeserializationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error during pipeliine parsing: {0}.
        /// </summary>
        internal static string PipelineParsingError {
            get {
                return ResourceManager.GetString("PipelineParsingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred whilst processing ModuleRefs from the the binding file in file {0}: {1}.
        /// </summary>
        internal static string ProcessModuleRefError {
            get {
                return ResourceManager.GetString("ProcessModuleRefError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred whilst processing ReceivePorts from the binding file in file {0}: {1}.
        /// </summary>
        internal static string ProcessReceivePortError {
            get {
                return ResourceManager.GetString("ProcessReceivePortError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred whilst processing Schemas from the assembly file {0}: {1}.
        /// </summary>
        internal static string ProcessSchemaError {
            get {
                return ResourceManager.GetString("ProcessSchemaError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred whilst processing Transforms from the assembly file {0}: {1}.
        /// </summary>
        internal static string ProcessTransformError {
            get {
                return ResourceManager.GetString("ProcessTransformError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to load a schema with type {0} because the assembly referenced in binding file is not included in list of assemblies supplied. Expected to find assembly called: {1}..
        /// </summary>
        internal static string SchemaFindAssemblyError {
            get {
                return ResourceManager.GetString("SchemaFindAssemblyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to load {0} type {1} from the assembly &apos;{2}&apos; as a dependent type can&apos;t be found. File Name is: {3}, FusionLog is {3}, error is: {4}.
        /// </summary>
        internal static string UnableToFindDependentTypeInAssembly {
            get {
                return ResourceManager.GetString("UnableToFindDependentTypeInAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find a {0} type called {1} in the assembly &apos;{2}&apos;..
        /// </summary>
        internal static string UnableToFindTypeInAssembly {
            get {
                return ResourceManager.GetString("UnableToFindTypeInAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred whilst loading the assembly file {0}: {1}.
        /// </summary>
        internal static string UnableToLoadAssembly {
            get {
                return ResourceManager.GetString("UnableToLoadAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to load {0} type {1} from the assembly &apos;{2}&apos; as a dependent type can&apos;t be loaded. File Name is: {3}, FusionLog is {4}, error is: {5}.
        /// </summary>
        internal static string UnableToLoadDependentTypeInAssembly {
            get {
                return ResourceManager.GetString("UnableToLoadDependentTypeInAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The supplied IParsedApplication instance is unsupported: Expected type {0}, received type {1}..
        /// </summary>
        internal static string UnsupportedParsedApplication {
            get {
                return ResourceManager.GetString("UnsupportedParsedApplication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WorkingDirectory cannot be null..
        /// </summary>
        internal static string WorkingDirectoryCannotBeNull {
            get {
                return ResourceManager.GetString("WorkingDirectoryCannotBeNull", resourceCulture);
            }
        }
    }
}