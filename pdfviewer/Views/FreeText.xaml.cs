using syncfusion.demoscommon.wpf;

namespace syncfusion.pdfviewerdemos.wpf
{
    /// <summary>
    /// Interaction logic for FreeText.xaml
    /// </summary>
    public partial class FreeText : DemoControl
    {
        public FreeText()
        {
            InitializeComponent();
        }
        public FreeText(string themename) : base(themename)
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            pdfviewer1.Unload(true);
            pdfviewer1 = null;
            if (this.DataContext is FreeTextViewModel)
            {
                (this.DataContext as FreeTextViewModel).DocumentStream.Dispose();
                this.DataContext = null;
            }
            base.Dispose(disposing);
        }
    }
}
