﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVVMbasics.CilInjection.NotifyPropertyChangedInjection.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MVVMbasics.CilInjection.NotifyPropertyChangedInjection.Resources.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Backup of the assembly file &quot;{0}&quot; could not be created. Error: {1}.
        /// </summary>
        internal static string Error_CreateBackupFailed {
            get {
                return ResourceManager.GetString("Error_CreateBackupFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not load assembly from file &quot;{0}&quot;. Error: {1}.
        /// </summary>
        internal static string Error_LoadAssembly {
            get {
                return ResourceManager.GetString("Error_LoadAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing property {0}: Injecting NotifyPropertyChanged invocation for dependent property {1}..
        /// </summary>
        internal static string Message_DependentPropertyProcessing {
            get {
                return ResourceManager.GetString("Message_DependentPropertyProcessing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property {0} depends on property {1}, storing dependency for NotifyPropertyChanged injection..
        /// </summary>
        internal static string Message_PropertyDependsOn {
            get {
                return ResourceManager.GetString("Message_PropertyDependsOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing property {0}: Injecting equality check and NotifyPropertyChanged invocation..
        /// </summary>
        internal static string Message_PropertyProcessing {
            get {
                return ResourceManager.GetString("Message_PropertyProcessing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not analyze class {0} because base type {1} could not be resolved. Error: {2}.
        /// </summary>
        internal static string Warning_BasetypeResolveFailed {
            get {
                return ResourceManager.GetString("Warning_BasetypeResolveFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not inject equality check into property {0}&apos;s setter method. Error: {1}.
        /// </summary>
        internal static string Warning_InjectEqualsInstructionsFailed {
            get {
                return ResourceManager.GetString("Warning_InjectEqualsInstructionsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not inject NotifyPropertyChanged invocation into property {0}&apos;s setter method. Error: {1}.
        /// </summary>
        internal static string Warning_InjectNotifyInstructionsFailed {
            get {
                return ResourceManager.GetString("Warning_InjectNotifyInstructionsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not resolve method System.Object.ReferenceEquals. Error:{0}.
        /// </summary>
        internal static string Warning_ResolveEqualsMethodFailed {
            get {
                return ResourceManager.GetString("Warning_ResolveEqualsMethodFailed", resourceCulture);
            }
        }
    }
}
