﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoopShoppingCom.Configuration {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    public sealed partial class CoopShoppingConfig : global::System.Configuration.ApplicationSettingsBase {
        
        private static CoopShoppingConfig defaultInstance = ((CoopShoppingConfig)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new CoopShoppingConfig())));
        
        public static CoopShoppingConfig Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Chrome")]
        public string Browser {
            get {
                return ((string)(this["Browser"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.co-operativebank.co.uk/")]
        public string BaseURL {
            get {
                return ((string)(this["BaseURL"]));
            }
        }
    }
}