using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Facts.iOS.Views
{
    [Register("FirstView")]
    public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView(){ BackgroundColor = UIColor.White};
            base.ViewDidLoad();

            var label = new UILabel(new RectangleF(10, 90, 300, 300));
            label.Lines = 0;
            Add(label);
            var nextFact = new UIButton(UIButtonType.RoundedRect);
            nextFact.SetTitle("Next Fact", UIControlState.Normal);
            nextFact.Frame = new RectangleF(10, 70, 300,50);
            Add(nextFact);
            nextFact.TitleLabel.Text = "Next Fact...";
            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(label).To(vm => vm.Fact);
            set.Bind(nextFact).To(vm => vm.NextFactCommand);
            set.Apply();

            
        }
    }
}