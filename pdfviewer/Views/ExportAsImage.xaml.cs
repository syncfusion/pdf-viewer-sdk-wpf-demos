using Syncfusion.Windows.Shared;
using System.ComponentModel;

namespace syncfusion.pdfviewerdemos.wpf
{
    /// <summary>
    /// Interaction logic for ExportasImage.xaml
    /// </summary>
    public partial class ExportAsImage : ChromelessWindow
    {
        public ExportAsImage()
        {
            InitializeComponent();
        }
        public ExportAsImage(string themeName)
        {
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            var viewModel = this.DataContext as ExportAsImageViewModel;
            if(viewModel != null)
            {
                viewModel.PageNumbers.Clear();
                viewModel.StartPageNumber = 0;
                viewModel.EndPageNumber = 0;
            }
            this.DataContext = null;
            base.OnClosing(e);
        }
    }
}
