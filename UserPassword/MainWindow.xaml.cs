using System;
using System.Windows;

namespace UserPassword
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(string time)
        {
            InitializeComponent();

            lbl_time.Content = time;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VideoWindow videoWindow = new VideoWindow();
            videoWindow.Show();
        } 
    }
}
