using syncfusion.demoscommon.wpf;

namespace syncfusion.pdfviewerdemos.wpf
{
    /// <summary>
    /// Interaction logic for SmartRedaction.xaml
    /// </summary>
    public partial class SmartRedaction : DemoControl
    {
        #region Constructor
        public SmartRedaction()
        {
            InitializeComponent();
        }
        #endregion
        public SmartRedaction(string themename) : base(themename)
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            pdfviewer1.Unload(true);
            pdfviewer1 = null;
            if (this.DataContext is SmartRedactionViewModel)
            {
                (this.DataContext as SmartRedactionViewModel).DocumentStream.Dispose();
                this.DataContext = null;
            }
            base.Dispose(disposing);
        }
    }
}