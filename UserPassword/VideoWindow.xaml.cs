using System;
using System.Windows;
using System.Configuration;
using System.Windows.Threading;

namespace UserPassword
{
    /// <summary>
    /// Логика взаимодействия для VideoWindow.xaml
    /// </summary>
    public partial class VideoWindow : Window
    {
        public VideoWindow()
        {
            InitializeComponent();

            me_video.Source = new Uri(ConfigurationManager.AppSettings.Get("video_file"));
            me_video.Play();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (me_video.Source != null)
            {
                if (me_video.NaturalDuration.HasTimeSpan)
                    lbl_status.Content = String.Format("{0} / {1}", me_video.Position.ToString(@"mm\:ss"), me_video.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            }
            else
                lbl_status.Content = "No file selected...";
        }

        private void bt_play_Click(object sender, RoutedEventArgs e)
        {
            me_video.Play();
        }

        private void bt_pause_Click(object sender, RoutedEventArgs e)
        {
            me_video.Pause();
        }

        private void bt_stop_Click(object sender, RoutedEventArgs e)
        {
            me_video.Stop();
        }
    }
}
