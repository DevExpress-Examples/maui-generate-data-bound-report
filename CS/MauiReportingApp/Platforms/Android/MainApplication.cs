using Android.App;
using Android.Runtime;
using DevExpress.Drawing;

namespace MauiReportingApp;

[Application]
public class MainApplication : MauiApplication {
    public MainApplication(IntPtr handle, JniHandleOwnership ownership)
        : base(handle, ownership) {
    }
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override void OnCreate() {

        using (StreamReader rd = new StreamReader(Assets.Open("Lobster-Regular.ttf"))) {
            using (var ms = new MemoryStream()) {
                rd.BaseStream.CopyTo(ms);

                DXFontRepository.Instance.AddFont(ms);
            }
        }
        using (StreamReader rd = new StreamReader(Assets.Open("OpenSans-Regular.ttf"))) {
            using (var ms = new MemoryStream()) {
                rd.BaseStream.CopyTo(ms);

                DXFontRepository.Instance.AddFont(ms);
            }
        }

        base.OnCreate();
    }
}