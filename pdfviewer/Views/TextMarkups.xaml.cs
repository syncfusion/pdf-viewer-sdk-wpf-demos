using syncfusion.demoscommon.wpf;

namespace syncfusion.pdfviewerdemos.wpf    
{
    /// <summary>
    /// Interaction logic for TextMarkups.xaml
    /// </summary>
    public partial class TextMarkups : DemoControl
    {
        public TextMarkups()
        {
            InitializeComponent();
        }
        public TextMarkups(string themename) : base(themename)
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            pdfviewer1.Unload(true);
            pdfviewer1 = null;
            if (this.DataContext is AnnotationsViewModel)
            {
                (this.DataContext as AnnotationsViewModel).DocumentStream.Dispose();
                this.DataContext = null;
            }
            base.Dispose(disposing);
        }
    }
}
