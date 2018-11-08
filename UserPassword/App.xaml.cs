using System.Diagnostics;
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
            Process thisProc = Process.GetCurrentProcess();
            if (Process.GetProcessesByName(thisProc.ProcessName).Length > 1)
            {
                Application.Current.Shutdown();
                return;
            }

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
