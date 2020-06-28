using CoolWeather.Extra.Navigation;
using CoolWeather.iOS.CustomRenderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomNavigationPage), typeof(CustomNavigationiOSRenderer))]
namespace CoolWeather.iOS.CustomRenderer
{
    public class CustomNavigationiOSRenderer : NavigationRenderer
    {
        public override void ViewDidLoad()
        {

            base.ViewDidLoad();

            UINavigationBar.Appearance.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
            UINavigationBar.Appearance.ShadowImage = new UIImage();
            UINavigationBar.Appearance.BackgroundColor = UIColor.Clear;
            UINavigationBar.Appearance.TintColor = UIColor.White;
            UINavigationBar.Appearance.BarTintColor = UIColor.Clear;
            UINavigationBar.Appearance.Translucent = true;
        }

        protected override void Dispose(bool disposing)
        {

            if (disposing)
            {
            }

            base.Dispose(disposing);
        }
    }
}
