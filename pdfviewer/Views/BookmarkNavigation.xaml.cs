using syncfusion.demoscommon.wpf;

namespace syncfusion.pdfviewerdemos.wpf
{
    /// <summary>
    /// Interaction logic for BookmarkNavigation.xaml
    /// </summary>
    public partial class BookmarkNavigation : DemoControl
    {
        public BookmarkNavigation()
        {
            InitializeComponent();
        }
        public BookmarkNavigation(string themename) : base(themename)
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            pdfviewer1.Unload(true);
            pdfviewer1 = null;
            if(this.DataContext is BookmarkNavigationViewModel)
            {
                (this.DataContext as BookmarkNavigationViewModel).DocumentStream.Dispose();
                this.DataContext = null;
            }
            base.Dispose(disposing); 
        }
    }
}
