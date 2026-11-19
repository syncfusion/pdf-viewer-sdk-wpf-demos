using Syncfusion.SfSkinManager;
using System.Windows;
using System.Windows.Controls;

namespace syncfusion.succinctlyseries.wpf
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FrontPage : Page
    {
        public FrontPage()
        {
            SfSkinManager.SetTheme(this, new Theme() { ThemeName = "Office2019Black" });
            this.InitializeComponent();
        }

        private void ReadButton_TouchDown(object sender, System.Windows.Input.TouchEventArgs e)
        {
            Button readButton = sender as Button;
            if (readButton.Command.CanExecute(true))
                readButton.Command.Execute(true);
        }
    }
}