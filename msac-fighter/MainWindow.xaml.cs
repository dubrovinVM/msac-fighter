using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToString("HH:mm:ss.fff");
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
