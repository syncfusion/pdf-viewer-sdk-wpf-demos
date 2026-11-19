using syncfusion.demoscommon.wpf;

namespace syncfusion.pdfviewerdemos.wpf
{
    /// <summary>
    /// Interaction logic for FormFIlling.xaml
    /// </summary>
    public partial class FormFilling : DemoControl
    {
        public FormFilling()
        {
            InitializeComponent();
        }
        public FormFilling(string themename) : base(themename)
        {
            InitializeComponent();            
        }
        protected override void Dispose(bool disposing)
        {
            pdfviewer1.Unload(true);
            pdfviewer1 = null;
            if (this.DataContext is FormFillingViewModel) 
            {
                (this.DataContext as FormFillingViewModel).DocumentStream.Dispose();
                this.DataContext = null;
            }
            base.Dispose(disposing);
        }
    }
}
