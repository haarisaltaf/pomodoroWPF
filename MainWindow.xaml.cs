using System.Text;
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

namespace pomodoroWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // define variables in class then utilise in method otherwise hard error
        DispatcherTimer timer;
        int interval = 1; // tick = 1 every second
        int maxInterval = 2400; // 40 mins in seconds

        public MainWindow()
        {
            InitializeComponent();

            // Init timer with DispatcherTimer function and then add tick method
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(interval);
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void TimerTick(object? sender, EventArgs e)
        {
            if (interval <= maxInterval)
            {
                TimerTextBox.Text = interval.ToString();
            } else
            {
                timer.Stop();
            }
            interval++;
        }
    }
}
