﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Automation.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.Automation.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The Automation account was not found..
        /// </summary>
        internal static string AutomationAccountNotFound {
            get {
                return ResourceManager.GetString("AutomationAccountNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing the Azure Automation schedule..
        /// </summary>
        internal static string RemoveAzureAutomationScheduleDescription {
            get {
                return ResourceManager.GetString("RemoveAzureAutomationScheduleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Azure Automation schedule?.
        /// </summary>
        internal static string RemoveAzureAutomationScheduleWarning {
            get {
                return ResourceManager.GetString("RemoveAzureAutomationScheduleWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Runbook was not found. Runbook name: {0}..
        /// </summary>
        internal static string RunbookNotFound {
            get {
                return ResourceManager.GetString("RunbookNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Automation schedule name is in use. Schedule name: {0}..
        /// </summary>
        internal static string ScheduleNameExists {
            get {
                return ResourceManager.GetString("ScheduleNameExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schedule was not found. Schedule name: {0}..
        /// </summary>
        internal static string ScheduleNotFound {
            get {
                return ResourceManager.GetString("ScheduleNotFound", resourceCulture);
            }
        }
    }
}
