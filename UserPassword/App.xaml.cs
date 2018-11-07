using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace UserPassword
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (e.Args.Length == 1)
            {
                MainWindow mainWindows = new MainWindow(e.Args[0]);
                mainWindows.Show();
            }
            else
            {
                App.Current.Shutdown(0);
            }
        }
    }
}
