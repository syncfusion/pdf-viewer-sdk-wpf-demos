using syncfusion.demoscommon.wpf;

namespace syncfusion.pdfviewerdemos.wpf
{
    /// <summary>
    /// Interaction logic for Redaction.xaml
    /// </summary>
    public partial class Redaction : DemoControl
    {
        public Redaction()
        {
            InitializeComponent();
        }
        public Redaction(string themename) : base(themename)
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            pdfviewer1.Unload(true);
            pdfviewer1 = null;
            if(this.DataContext is RedactionViewModel)
            {
                (this.DataContext as RedactionViewModel).DocumentStream.Dispose();
                this.DataContext = null;
            }
            base.Dispose(disposing);
        }
    }
   
}
