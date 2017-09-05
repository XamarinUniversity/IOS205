using Foundation;
using System;
using UIKit;
using System.Timers;

namespace Clock
{
	partial class ClockViewController : UIViewController
	{
		NSObject willEnterForegroundObserver;
		NSObject didEnterBackgroundObserver;

		Timer clockTimer;

		public ClockViewController (IntPtr handle) : base (handle)
		{
		}

		void UpdateTime ()
		{
			InvokeOnMainThread (() => {
				lblTime.Text = DateTime.Now.ToShortTimeString ();
				lblSeconds.Text = DateTime.Now.Second.ToString ("00");
				lblAmPm.Text = (DateTime.Now.Hour >= 12) ? "PM" : "AM";
			});
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			clockTimer = new Timer (1000);

			clockTimer.Elapsed += (s, e) => UpdateTime();
			clockTimer.Start ();


			willEnterForegroundObserver = UIApplication.Notifications.ObserveWillEnterForeground ((s, e) => {
				if(clockTimer != null)
					clockTimer.Start();
			});

			didEnterBackgroundObserver = UIApplication.Notifications.ObserveDidEnterBackground ((s, e) => {
				if (clockTimer != null)
					clockTimer.Stop();
			});

			UpdateTime ();
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);

			willEnterForegroundObserver.Dispose();
			didEnterBackgroundObserver.Dispose();

			clockTimer.Stop ();
			clockTimer = null;
		}
	}
}