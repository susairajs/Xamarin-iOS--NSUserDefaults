// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamariniOSUserDefaults
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblBoolean { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblInteger { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblString { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch switchOnOff { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtInteger { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtString { get; set; }

        [Action ("UIButton12_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton12_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (lblBoolean != null) {
                lblBoolean.Dispose ();
                lblBoolean = null;
            }

            if (lblInteger != null) {
                lblInteger.Dispose ();
                lblInteger = null;
            }

            if (lblString != null) {
                lblString.Dispose ();
                lblString = null;
            }

            if (switchOnOff != null) {
                switchOnOff.Dispose ();
                switchOnOff = null;
            }

            if (txtInteger != null) {
                txtInteger.Dispose ();
                txtInteger = null;
            }

            if (txtString != null) {
                txtString.Dispose ();
                txtString = null;
            }
        }
    }
}