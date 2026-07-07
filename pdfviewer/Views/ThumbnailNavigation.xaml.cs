using syncfusion.demoscommon.wpf;

namespace syncfusion.pdfviewerdemos.wpf
{
    /// <summary>
    /// Interaction logic for ThumbnailNavigation.xaml
    /// </summary>
    public partial class ThumbnailNavigation : DemoControl
    {
        public ThumbnailNavigation()
        {
            InitializeComponent();
        }
        public ThumbnailNavigation(string themename) : base(themename)
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            pdfviewer1.Unload(true);
            pdfviewer1 = null;
            if (this.DataContext is ThumbnailNavigationViewModel)
            {
                (this.DataContext as ThumbnailNavigationViewModel).DocumentStream.Dispose();
                this.DataContext = null;
            }
            base.Dispose(disposing);
        }
    }
}
