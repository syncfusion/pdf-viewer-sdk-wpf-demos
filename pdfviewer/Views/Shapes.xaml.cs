using syncfusion.demoscommon.wpf;

namespace syncfusion.pdfviewerdemos.wpf
{
    /// <summary>
    /// Interaction logic for Shapes.xaml
    /// </summary>
    public partial class Shapes : DemoControl
    {
        public Shapes()
        {
            InitializeComponent();
            pdfviewer1.CommentSettings.IsExpanded = true;
        }
        public Shapes(string themename) : base(themename)
        {
            InitializeComponent();
            pdfviewer1.CommentSettings.IsExpanded = true;
        }
        protected override void Dispose(bool disposing)
        {
            pdfviewer1.Unload(true);
            pdfviewer1 = null;
            if(this.DataContext is AnnotationsViewModel)
            {
                (this.DataContext as AnnotationsViewModel).DocumentStream.Dispose();
                this.DataContext = null;
            }
            base.Dispose(disposing);
        }
    }
}
