// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace DemoBindingNXPlacePicker
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSelectPlace { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSelectedPlace { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnSelectPlace != null) {
                btnSelectPlace.Dispose ();
                btnSelectPlace = null;
            }

            if (lblSelectedPlace != null) {
                lblSelectedPlace.Dispose ();
                lblSelectedPlace = null;
            }
        }
    }
}