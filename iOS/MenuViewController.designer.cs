// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Wendy.iOS
{
	[Register ("MenuViewController")]
	partial class MenuViewController
	{
		[Outlet]
		UIKit.UIButton btnMap { get; set; }

		[Outlet]
		UIKit.UIButton btnWeb { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnMap != null) {
				btnMap.Dispose ();
				btnMap = null;
			}

			if (btnWeb != null) {
				btnWeb.Dispose ();
				btnWeb = null;
			}
		}
	}
}
