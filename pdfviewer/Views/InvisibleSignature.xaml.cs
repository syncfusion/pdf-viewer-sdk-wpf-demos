using syncfusion.demoscommon.wpf;

namespace syncfusion.pdfviewerdemos.wpf
{
    /// <summary>
    /// Interaction logic for InvisibleSignature.xaml
    /// </summary>
    public partial class InvisibleSignature : DemoControl
    {
        public InvisibleSignature()
        {
            InitializeComponent();
        }
        public InvisibleSignature(string themename) : base(themename)
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            pdfviewer1.ShowToolbar = true;
            pdfviewer1.IsBookmarkEnabled = true;
            pdfviewer1.ThumbnailSettings.IsVisible = true;
            pdfviewer1.EnableLayers = true;
            pdfviewer1.PageOrganizerSettings.IsIconVisible = true;
            pdfviewer1.EnableRedactionTool = true;
            pdfviewer1.FormSettings.IsIconVisible = true;
            pdfviewer1.Unload(true);
            pdfviewer1 = null;
            if (this.DataContext is InvisibleSignatureViewModel)
            {
                (this.DataContext as InvisibleSignatureViewModel).DocumentStream.Dispose();
                if ((this.DataContext as InvisibleSignatureViewModel).SignatureStream != null)
                    (this.DataContext as InvisibleSignatureViewModel).SignatureStream.Dispose();
                this.DataContext = null;
            }
            base.Dispose(disposing);
        }
    }
}
