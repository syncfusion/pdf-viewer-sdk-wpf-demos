using syncfusion.succinctlyseries.wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace syncfusion.succinctlyseries.wpf_47
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var window = Activator.CreateInstance(typeof(SuccinctlySeriesDemo)) as Window;
            window.Show();
            base.OnStartup(e);
        }
    }
}
