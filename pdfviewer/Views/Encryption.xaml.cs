using syncfusion.demoscommon.wpf;

namespace syncfusion.pdfviewerdemos.wpf
{
    /// <summary>
    /// Interaction logic for InkSignature.xaml
    /// </summary>
    public partial class Encryption : DemoControl
    {
        public Encryption()
        {
            InitializeComponent();
        }

        public Encryption(string themename) : base(themename)
        {
            InitializeComponent(); 
        }

        protected override void Dispose(bool disposing)
        {
            pdfviewer1.Unload(true);
            pdfviewer1 = null;
            if (this.DataContext is InkSignatureViewModel)
            {
                (this.DataContext as InkSignatureViewModel).DocumentStream.Dispose();
                this.DataContext = null;
            }
            base.Dispose(disposing);
        }
    }
}
