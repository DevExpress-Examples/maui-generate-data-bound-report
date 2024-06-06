using DevExpress.Drawing;
using Foundation;
using UIKit;

namespace MauiReportingApp;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions) {

        var bundlePath = Foundation.NSBundle.MainBundle.BundlePath;
        var fontPath = Path.Combine(bundlePath, "Lobster-Regular.ttf");
        var fontStream = new MemoryStream(File.ReadAllBytes(fontPath));
        DXFontRepository.Instance.AddFont(fontStream);

        fontPath = Path.Combine(bundlePath, "OpenSans-Regular.ttf");
        fontStream = new MemoryStream(File.ReadAllBytes(fontPath));
        DXFontRepository.Instance.AddFont(fontStream);
        return base.FinishedLaunching(application, launchOptions);
    }
}
