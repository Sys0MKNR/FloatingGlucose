﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FloatingGlucose.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://...")]
        public string nightscout_site {
            get {
                return ((string)(this["nightscout_site"]));
            }
            set {
                this["nightscout_site"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool enable_exception_logging_to_stderr {
            get {
                return ((bool)(this["enable_exception_logging_to_stderr"]));
            }
            set {
                this["enable_exception_logging_to_stderr"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int refresh_interval_in_seconds {
            get {
                return ((int)(this["refresh_interval_in_seconds"]));
            }
            set {
                this["refresh_interval_in_seconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public float gui_scaling_ratio {
            get {
                return ((float)(this["gui_scaling_ratio"]));
            }
            set {
                this["gui_scaling_ratio"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool on_startup_show_buttons {
            get {
                return ((bool)(this["on_startup_show_buttons"]));
            }
            set {
                this["on_startup_show_buttons"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool enable_alarms {
            get {
                return ((bool)(this["enable_alarms"]));
            }
            set {
                this["enable_alarms"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("13")]
        public decimal alarm_urgent_high {
            get {
                return ((decimal)(this["alarm_urgent_high"]));
            }
            set {
                this["alarm_urgent_high"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("11")]
        public decimal alarm_high {
            get {
                return ((decimal)(this["alarm_high"]));
            }
            set {
                this["alarm_high"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4.5")]
        public decimal alarm_low {
            get {
                return ((decimal)(this["alarm_low"]));
            }
            set {
                this["alarm_low"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3.8")]
        public decimal alarm_urgent_low {
            get {
                return ((decimal)(this["alarm_urgent_low"]));
            }
            set {
                this["alarm_urgent_low"] = value;
            }
        }
    }
}