﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HIDControllers {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HIDControllers.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The {0} Controller&apos;s {1} control must be a boolean!.
        /// </summary>
        internal static string ButtonNotBoolean {
            get {
                return ResourceManager.GetString("ButtonNotBoolean", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} Controller&apos;s {1} control button number was incalculable!.
        /// </summary>
        internal static string ButtonNumberUnknown {
            get {
                return ResourceManager.GetString("ButtonNumberUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} Controller&apos;s {1} control value changed from {2} to {3}..
        /// </summary>
        internal static string ControlChange {
            get {
                return ResourceManager.GetString("ControlChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create control, expected {0} control, but received {1} control..
        /// </summary>
        internal static string ControlCreationFailure2 {
            get {
                return ResourceManager.GetString("ControlCreationFailure2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} controller was found..
        /// </summary>
        internal static string ControllerAdd {
            get {
                return ResourceManager.GetString("ControllerAdd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when a new Controller is found and successfully added..
        /// </summary>
        internal static string ControllerAddDescription {
            get {
                return ResourceManager.GetString("ControllerAddDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not create the {0} controller!.
        /// </summary>
        internal static string ControllerCreationFailure {
            get {
                return ResourceManager.GetString("ControllerCreationFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when an exception is thrown whilst trying to create a Controller class, usually this is an access violation..
        /// </summary>
        internal static string ControllerCreationFailureDescription {
            get {
                return ResourceManager.GetString("ControllerCreationFailureDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} controller&apos;s input could not be parsed!.
        /// </summary>
        internal static string ControllerInputParseFailure {
            get {
                return ResourceManager.GetString("ControllerInputParseFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when the data sent from a Controller could not be parsed successfully..
        /// </summary>
        internal static string ControllerInputParseFailureDescription {
            get {
                return ResourceManager.GetString("ControllerInputParseFailureDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} controller was removed..
        /// </summary>
        internal static string ControllerRemove {
            get {
                return ResourceManager.GetString("ControllerRemove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when a Controller is unplugged..
        /// </summary>
        internal static string ControllerRemoveDescription {
            get {
                return ResourceManager.GetString("ControllerRemoveDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} controller&apos;s HIDStream stopped unexpectedly!.
        /// </summary>
        internal static string ControllerStreamStopped {
            get {
                return ResourceManager.GetString("ControllerStreamStopped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when a Controller&apos;s HIDStream stops unexpectedly..
        /// </summary>
        internal static string ControllerStreamStoppedDescription {
            get {
                return ResourceManager.GetString("ControllerStreamStoppedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} controller was updated..
        /// </summary>
        internal static string ControllerUpdate {
            get {
                return ResourceManager.GetString("ControllerUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when a Controller&apos;s definition is changed..
        /// </summary>
        internal static string ControllerUpdateDescription {
            get {
                return ResourceManager.GetString("ControllerUpdateDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vendor: {0}; Product ID: {1}; Release: {2}.
        /// </summary>
        internal static string DefaultControllerName {
            get {
                return ResourceManager.GetString("DefaultControllerName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Consumer Controller.
        /// </summary>
        internal static string DeviceTypeConsumerController {
            get {
                return ResourceManager.GetString("DeviceTypeConsumerController", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gamepad.
        /// </summary>
        internal static string DeviceTypeGamepad {
            get {
                return ResourceManager.GetString("DeviceTypeGamepad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Joystick.
        /// </summary>
        internal static string DeviceTypeJoystick {
            get {
                return ResourceManager.GetString("DeviceTypeJoystick", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keypad.
        /// </summary>
        internal static string DeviceTypeKeypad {
            get {
                return ResourceManager.GetString("DeviceTypeKeypad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multi-axis Controller.
        /// </summary>
        internal static string DeviceTypeMultiAxisController {
            get {
                return ResourceManager.GetString("DeviceTypeMultiAxisController", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Programmable Buttons.
        /// </summary>
        internal static string DeviceTypeProgrammableButtons {
            get {
                return ResourceManager.GetString("DeviceTypeProgrammableButtons", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} HAT controller does not have a nullable value so is unsupported!.
        /// </summary>
        internal static string HatNotNullable {
            get {
                return ResourceManager.GetString("HatNotNullable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not open the HIDStream for the {0} Controller..
        /// </summary>
        internal static string HidStreamOpenFailure {
            get {
                return ResourceManager.GetString("HidStreamOpenFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dead zone must be between 0 and 1..
        /// </summary>
        internal static string InvalidDeadZone {
            get {
                return ResourceManager.GetString("InvalidDeadZone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Sensitivity must be between 0 and 15 decimal places..
        /// </summary>
        internal static string InvalidSensitivity {
            get {
                return ResourceManager.GetString("InvalidSensitivity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HID controllers failed to update!.
        /// </summary>
        internal static string RefreshFailure {
            get {
                return ResourceManager.GetString("RefreshFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when an exception is thrown whilst trying to load the Controllers collection on a change being detected to the list of HID Devices..
        /// </summary>
        internal static string RefreshFailureDescription {
            get {
                return ResourceManager.GetString("RefreshFailureDescription", resourceCulture);
            }
        }
    }
}
