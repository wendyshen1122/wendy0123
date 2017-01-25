using System;

using UIKit;

namespace Wendy.iOS
{
	public partial class LoginViewController : UIViewController
	{
		public LoginViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			//發生什麼事時，去做什麼(委派)
			btnLogin.TouchUpInside += (sender, e) =>
			{
				PerformSegue("moveToMenuSegue", this);


			};

			//上述委派還可以寫成如下(當發生什麼事時，呼叫Todo)
			//btnLogin.TouchUpInside += Todosomething; 

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		//void Todosomething(object sender, EventArgs e) { }
	}
}

