﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataDictionaryCreator.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string FOREIGN_KEY_DESCRIPTION {
            get {
                return ((string)(this["FOREIGN_KEY_DESCRIPTION"]));
            }
            set {
                this["FOREIGN_KEY_DESCRIPTION"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string PRIMARY_KEY_DESCRIPTION {
            get {
                return ((string)(this["PRIMARY_KEY_DESCRIPTION"]));
            }
            set {
                this["PRIMARY_KEY_DESCRIPTION"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool ALLOW_OVERWRITE {
            get {
                return ((bool)(this["ALLOW_OVERWRITE"]));
            }
            set {
                this["ALLOW_OVERWRITE"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string SQL_CONNECTION_STRING {
            get {
                return ((string)(this["SQL_CONNECTION_STRING"]));
            }
            set {
                this["SQL_CONNECTION_STRING"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string ADDITIONAL_PROPERTIES {
            get {
                return ((string)(this["ADDITIONAL_PROPERTIES"]));
            }
            set {
                this["ADDITIONAL_PROPERTIES"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::DataDictionaryCreator.ExcludedObjectList ExcludedObjects {
            get {
                return ((global::DataDictionaryCreator.ExcludedObjectList)(this["ExcludedObjects"]));
            }
            set {
                this["ExcludedObjects"] = value;
            }
        }
    }
}
