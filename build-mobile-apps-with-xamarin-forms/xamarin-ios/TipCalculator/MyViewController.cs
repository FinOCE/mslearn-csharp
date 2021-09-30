using System;
using UIKit;
using CoreGraphics;

namespace TipCalculator
{
    class MyViewController : UIViewController
    {
        private UITextField totalAmount;
        private UIButton calcButton;
        private UILabel resultLabel;

        public MyViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.View.BackgroundColor = UIColor.Yellow;
            var topPadding = UIApplication.SharedApplication.Windows[0].SafeAreaInsets.Top;

            totalAmount = new UITextField(new CGRect(20, 28 + topPadding, View.Bounds.Width - 40, 35))
            {
                KeyboardType = UIKeyboardType.DecimalPad,
                BorderStyle = UITextBorderStyle.RoundedRect,
                Placeholder = "Enter Total amount"
            };

            calcButton = new UIButton(UIButtonType.Custom)
            {
                Frame = new CGRect(20, 71 + topPadding, View.Bounds.Width - 40, 45),
                BackgroundColor = UIColor.FromRGB(0, 0.5f, 0)
            };
            calcButton.SetTitle("Calculate", UIControlState.Normal);

            resultLabel = new UILabel(new CGRect(20, 124 + topPadding, View.Bounds.Width - 40, 40))
            {
                TextColor = UIColor.Blue,
                TextAlignment = UITextAlignment.Center,
                Font = UIFont.SystemFontOfSize(24),
                Text = "Tip is $0.00"
            };

            View.AddSubviews(totalAmount, calcButton, resultLabel);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            calcButton.TouchUpInside += CalcButton_TouchUpInside;
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            calcButton.TouchUpInside -= CalcButton_TouchUpInside;
        }

        void CalcButton_TouchUpInside(object sender, EventArgs e)
        {
            if (Double.TryParse(totalAmount.Text, out double value))
            {
                resultLabel.Text = string.Format("Tip is {0:C}", GetTip(value, 20));
            }
            else
            {
                resultLabel.Text = "Please enter a valid amount";
            }

            totalAmount.ResignFirstResponder();
        }

        public double GetTip(double amount, double percentage)
        {
            return amount * percentage / 100.0;
        }
    }
}