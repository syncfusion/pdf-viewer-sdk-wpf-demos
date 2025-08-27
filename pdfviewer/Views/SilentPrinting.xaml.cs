using Syncfusion.Windows.Shared;
using System.ComponentModel;

namespace syncfusion.pdfviewerdemos.wpf
{
    /// <summary>
    /// Interaction logic for SilentPrinting.xaml
    /// </summary>
    public partial class SilentPrinting : ChromelessWindow
    {
        public SilentPrinting()
        {
            InitializeComponent();
        }
        public SilentPrinting(string themeName)
        {
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            this.DataContext = null;
            base.OnClosing(e);
        }
    }
}
