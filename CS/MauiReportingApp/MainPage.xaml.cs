using ReportLibrary;
using ReportLibrary.Data;
using DevExpress.Drawing;
using DevExpress.Maui.Pdf;
using DevExpress.XtraReports.UI;

namespace MauiReportingApp;

public partial class MainPage : ContentPage {
    public MainPage() {
        InitializeComponent();
    }

    public async Task<XtraReport> CreateTableReportAsync() {
        XtraReportInstance report = null;
        await Task.Run(() =>
        {
            report = new XtraReportInstance() { Name = "Sample" };
            report.CreateDocument();
        });
        return report;
    }

    private async void ContentPage_Loaded(object sender, EventArgs e) {
        XtraReport report = await CreateTableReportAsync();
        string resultFile = Path.Combine(FileSystem.Current.AppDataDirectory, report.Name + ".pdf");
        report.ExportToPdf(resultFile);
        pdfViewer.DocumentSource = PdfDocumentSource.FromFile(resultFile);
        loadingShimmer.IsLoading = false;
    }
}
