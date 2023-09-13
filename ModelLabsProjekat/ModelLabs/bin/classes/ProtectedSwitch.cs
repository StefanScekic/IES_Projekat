//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FTN {
    using System;
    using FTN;
    
    
    /// A ProtectedSwitch is a switching device that can be operated by ProtectionEquipment.
    public class ProtectedSwitch : Switch {
        
        /// The maximum fault current a breaking device can break safely under prescribed conditions of use.
        private System.Single? cim_breakingCapacity;
        
        private const bool isBreakingCapacityMandatory = false;
        
        private const string _breakingCapacityPrefix = "cim";
        
        public virtual float BreakingCapacity {
            get {
                return this.cim_breakingCapacity.GetValueOrDefault();
            }
            set {
                this.cim_breakingCapacity = value;
            }
        }
        
        public virtual bool BreakingCapacityHasValue {
            get {
                return this.cim_breakingCapacity != null;
            }
        }
        
        public static bool IsBreakingCapacityMandatory {
            get {
                return isBreakingCapacityMandatory;
            }
        }
        
        public static string BreakingCapacityPrefix {
            get {
                return _breakingCapacityPrefix;
            }
        }
    }
}