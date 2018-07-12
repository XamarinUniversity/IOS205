using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using WebKit;

namespace Clock
{
	partial class AboutViewController : UIViewController, IWKNavigationDelegate
	{
		public AboutViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			EdgesForExtendedLayout = UIRectEdge.None;

			var aboutUrl = NSUrl.FromFilename(NSBundle.MainBundle.BundlePath + "/About.html");
			AboutWebView.NavigationDelegate = this;
			AboutWebView.LoadFileUrl(aboutUrl, aboutUrl.RemoveLastPathComponent());
		}

		[Export("webView:decidePolicyForNavigationAction:decisionHandler:")]
		public void DecidePolicy(WKWebView webView, WKNavigationAction navigationAction, Action<WKNavigationActionPolicy> decisionHandler)
		{
			// Load the "about.html" file locally inside the web view but open the links in there in external browser.
			if (navigationAction.Request.Url.IsFileUrl)
			{
				decisionHandler(WKNavigationActionPolicy.Allow);
			}
			else
			{
				decisionHandler(WKNavigationActionPolicy.Cancel);
				UIApplication.SharedApplication.OpenUrl(navigationAction.Request.Url);
			}
		}
	}
}
