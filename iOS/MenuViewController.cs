using System;

using UIKit;

namespace Wendy.iOS
{
	public partial class MenuViewController : UIViewController
	{
		public MenuViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			btnMap.TouchUpInside += (sender, e) =>
			{
				PerformSegue("moveToMapSegue", this);
			};

			btnWeb.TouchUpInside += (sender, e) =>
			{
				PerformSegue("moveToWebSegue", this);
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

