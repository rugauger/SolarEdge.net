﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SolarEdgeService {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
    public sealed partial class SolarEdgeServiceSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static SolarEdgeServiceSettings defaultInstance = ((SolarEdgeServiceSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new SolarEdgeServiceSettings())));
        
        public static SolarEdgeServiceSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutorunServicesInGUIMode {
            get {
                return ((bool)(this["AutorunServicesInGUIMode"]));
            }
            set {
                this["AutorunServicesInGUIMode"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        public int RefreshIntervalMs {
            get {
                return ((int)(this["RefreshIntervalMs"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10.0.1.116")]
        public string IPAdress {
            get {
                return ((string)(this["IPAdress"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("502")]
        public int ModBusPort {
            get {
                return ((int)(this["ModBusPort"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2500")]
        public int ConnectionTimeoutMs {
            get {
                return ((int)(this["ConnectionTimeoutMs"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2000")]
        public int MinIntervalBetweenUpdatesMs {
            get {
                return ((int)(this["MinIntervalBetweenUpdatesMs"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ReadInverterData {
            get {
                return ((bool)(this["ReadInverterData"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ReadMeterData {
            get {
                return ((bool)(this["ReadMeterData"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("UpdateExistingObjects")]
        public string DataUpdateMode {
            get {
                return ((string)(this["DataUpdateMode"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10000")]
        public int HeartbeatTimerIntervalMs {
            get {
                return ((int)(this["HeartbeatTimerIntervalMs"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ResetHeartbeatTimerOnDataUpdates {
            get {
                return ((bool)(this["ResetHeartbeatTimerOnDataUpdates"]));
            }
        }
    }
}
