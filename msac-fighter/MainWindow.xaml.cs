using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace msac_fighter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public int timer_minutes;
        public int timer_seconds;
        public int timer_miliseconds;
        private const string zero = "00";

        public MainWindow()
        {
            InitializeComponent();

            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(1);
            dispatcherTimer.Tick += Timer_Tick;
        }

        private void startbtn_Click(object sender, RoutedEventArgs e)
        {
            timer_minutes = string.IsNullOrEmpty(LblTimeMin.Text) ? 3 : Convert.ToInt32(LblTimeMin.Text);
            timer_seconds = string.IsNullOrEmpty(LblTimeSec.Text) ? 0 : Convert.ToInt32(LblTimeSec.Text);
            timer_miliseconds = string.IsNullOrEmpty(LblTimeMiliSec.Text) ? 00 : Convert.ToInt32(LblTimeMiliSec.Text);
            dispatcherTimer.Start();
        }

        private void stopbtn_Click(object sender, RoutedEventArgs e)
        {
             dispatcherTimer.Stop();
        }

        private void resetbtn_Click(object sender, RoutedEventArgs e)
        {
            LblTimeMin.Text = zero;
            LblTimeSec.Text = zero;
            LblTimeMiliSec.Text = zero;
        }

        void Timer_Tick(object sender, EventArgs e)
        {

            timer_miliseconds--;

            if (timer_miliseconds == -1)
            {
                timer_seconds--;
                timer_miliseconds = 99;
            }

            if (timer_seconds==-1)
            {
                timer_minutes--;
                timer_seconds = 59;
            }

            if (timer_seconds == 0 && timer_minutes==0 && timer_miliseconds == 0)
            {
                dispatcherTimer.Stop();
            }

            LblTimeMin.Text = timer_minutes.ToString("D2");
            LblTimeSec.Text = timer_seconds.ToString("D2");
            LblTimeMiliSec.Text = timer_miliseconds.ToString("D2");

        }
        private void RadioButtonMen_Clicked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            if (pressed.Name == nameof(Men))
            {
                Women.IsChecked = false;
            }
            else
            {
                Men.IsChecked = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button pressed = (Button)sender;
            if (pressed.Name == nameof(ButtonFrom))
            {
                ButtonFrom.FontWeight = FontWeights.Bold;
                ButtonTo.FontWeight = FontWeights.Normal;
            }
            else
            {
                ButtonFrom.FontWeight = FontWeights.Normal;
                ButtonTo.FontWeight = FontWeights.Bold;
            }
        }

       
    }
}
