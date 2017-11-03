using System;

using UIKit;

namespace RestTest
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            TestButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                var result = CommunicationTest.GetTest();
                if (result != "") {
                    ResultTextView.Text = result;
                }
            };

            TestPostButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                var result = CommunicationTest.WebClientPost();
                if (result != null)
                {
                    ResultTextView.Text = System.Text.Encoding.Default.GetString(result);
                }
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
