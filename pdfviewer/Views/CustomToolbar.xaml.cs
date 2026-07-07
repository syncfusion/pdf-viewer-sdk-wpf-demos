using Syncfusion.SfSkinManager;
using Syncfusion.Windows.Tools.Controls;

namespace syncfusion.pdfviewerdemos.wpf
{
    /// <summary>
    /// Interaction logic for CustomToolbar.xaml
    /// </summary>
    public partial class CustomToolbar : RibbonWindow
    {
        public CustomToolbar()
        {
            SfSkinManager.SetTheme(this, new Theme() { ThemeName = "Office2019Colorful" });
            InitializeComponent();
        }
    }
}
