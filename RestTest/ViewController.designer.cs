// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace RestTest
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ResponseLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView ResultTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton TestButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton TestPostButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ResponseLabel != null) {
                ResponseLabel.Dispose ();
                ResponseLabel = null;
            }

            if (ResultTextView != null) {
                ResultTextView.Dispose ();
                ResultTextView = null;
            }

            if (TestButton != null) {
                TestButton.Dispose ();
                TestButton = null;
            }

            if (TestPostButton != null) {
                TestPostButton.Dispose ();
                TestPostButton = null;
            }
        }
    }
}