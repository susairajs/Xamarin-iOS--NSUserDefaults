using System;
using UIKit;
using Foundation;

namespace XamariniOSUserDefaults
{
	public partial class ViewController : UIViewController
	{
		NSUserDefaults storevalues = new NSUserDefaults();

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			switchOnOff.On = false;
			switchOnOff.ValueChanged += (sender, e) =>
			{
				if (switchOnOff.On == true)
				{
				    //Store value on Userdefaults
					storevalues.SetBool(switchOnOff.On = true, "swithvalue");
				}
				else
				{
                    //Store value on Userdefaults
					storevalues.SetBool(switchOnOff.On = false, "swithvalue");
				}
			};
		}
		partial void UIButton12_TouchUpInside(UIButton sender)
		{
            //Store value on Userdefaults
			storevalues.SetString(txtString.Text, "stringvalue");
			storevalues.SetInt(Int32.Parse(txtInteger.Text), "integervalue");

			//Get values form Userdefaults

			lblString.Text = storevalues.StringForKey("stringvalue");
			lblInteger.Text = storevalues.IntForKey("integervalue").ToString();
			lblBoolean.Text = storevalues.BoolForKey("swithvalue").ToString();;


		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
