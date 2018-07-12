// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Clock
{
    [Register ("StopwatchViewController")]
    partial class StopwatchViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSplit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnStart { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnViewSplits { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblElapsed { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLastSplit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewStopwatchBackground { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnSplit != null) {
                btnSplit.Dispose ();
                btnSplit = null;
            }

            if (btnStart != null) {
                btnStart.Dispose ();
                btnStart = null;
            }

            if (btnViewSplits != null) {
                btnViewSplits.Dispose ();
                btnViewSplits = null;
            }

            if (lblElapsed != null) {
                lblElapsed.Dispose ();
                lblElapsed = null;
            }

            if (lblLastSplit != null) {
                lblLastSplit.Dispose ();
                lblLastSplit = null;
            }

            if (viewStopwatchBackground != null) {
                viewStopwatchBackground.Dispose ();
                viewStopwatchBackground = null;
            }
        }
    }
}