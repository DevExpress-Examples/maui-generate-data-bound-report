using DevExpress.Drawing;
using DevExpress.Maui;
using DevExpress.Maui.Core;
using DotNet.Meteor.HotReload.Plugin;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace MauiReportingApp;

public static class MauiProgram {
    public static MauiApp CreateMauiApp() {
        ThemeManager.ApplyThemeToSystemBars = true;
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseDevExpress(useLocalization: true)
            .UseSkiaSharp()
            .EnableHotReload()
            .ConfigureFonts(fonts => {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("univia-pro-regular.ttf", "Univia-Pro");
                fonts.AddFont("roboto-bold.ttf", "Roboto-Bold");
                fonts.AddFont("roboto-regular.ttf", "Roboto");
                fonts.AddFont("Lobster-Regular.ttf", "Lobster");
            });
        return builder.Build();
    }
}
