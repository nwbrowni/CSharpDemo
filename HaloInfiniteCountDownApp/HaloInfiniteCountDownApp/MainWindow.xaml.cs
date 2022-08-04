using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
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

namespace HaloInfiniteCountDownApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer backgroundtimer = new DispatcherTimer();
        List<Image> ImageList = new List<Image>();
        // for testing: int x = 0;

        public MainWindow()
        {
            InitializeComponent();

            // set up timers
            timer.Interval = new TimeSpan(1000000);  // expressed in ticks (= 100 nanoseconds)
            //for millisecond, use TimeSpan(1000000) (million)
            //for second, use TimeSpan(1000000) (10 million)
            timer.Tick += new EventHandler(Timer_Elapsed);
            timer.Start();

            backgroundtimer.Interval = new TimeSpan(100000000);  // 10 seconds?
            backgroundtimer.Tick += new EventHandler(BackgroundTimer_Elapsed);
            backgroundtimer.Start();

            // set up the list containing all the background images
            ImageList.Add(MarinesImage);
            ImageList.Add(RingImage);
            ImageList.Add(SpartanHelmetImage);
            ImageList.Add(MasterChiefImage);

            // set up the initial image visibilities
            MarinesImage.Visibility = Visibility.Visible;
            RingImage.Visibility = Visibility.Hidden;
            SpartanHelmetImage.Visibility = Visibility.Hidden;
            MasterChiefImage.Visibility = Visibility.Hidden;

            DaysTillReleaseTextBlock.Visibility = Visibility.Visible;
        }

        private void SlideShowRotate()
        {
            int i = 0;

            // go through the entire list
            while (i < ImageList.Count)
            {
                // if at the currently visible image
                if (ImageList[i].Visibility == Visibility.Visible)
                {
                    // make currently visible image (background) hidden
                    ImageList[i].Visibility = Visibility.Hidden;

                    if (i == (ImageList.Count - 1))
                    {
                        // if last, set first one as background (visible)
                        ImageList[0].Visibility = Visibility.Visible;
                    }
                    else
                    {
                        // otherwise, make the next image the background (visible)
                        ImageList[i + 1].Visibility = Visibility.Visible;
                    }

                    // break out (so doesn't make next hidden again)
                    return;
                }
                else
                {
                    // hide all others
                    ImageList[i].Visibility = Visibility.Hidden;
                }

                // increment through the list
                i++;
            }
        }

        private async void Timer_Elapsed(object sender, EventArgs e)
        {
            await DaysTillInfiniteRelease();
        }

        private async void BackgroundTimer_Elapsed(object sender, EventArgs e)
        {
            await BackgroundSlideShow();
        }

        public Task BackgroundSlideShow()
        {
            return Task.Factory.StartNew(() => SelectNextBackground());
        }

        private void SelectNextBackground()
        {
            // since working on controls, cannot do it from a separate thread
            Dispatcher.BeginInvoke((Action)(() =>
            {
                SlideShowRotate();
            }));
        }

        public Task DaysTillInfiniteRelease()
        {
            return Task.Factory.StartNew(() => UpdateDaysTillInfiniteReleaseLabels());
        }

        private void UpdateDaysTillInfiniteReleaseLabels()
        {
            DateTime today = DateTime.Parse(DateTime.Now.ToString());
            DateTime release = DateTime.Parse("12/08/2021");

            int days = (release - today).Days;
            int hours = (release - today).Hours;
            int minutes = (release - today).Minutes;
            int seconds = (release - today).Seconds;
            String output = $" {days}d {hours}h {minutes}m {seconds}s";

            Dispatcher.BeginInvoke((Action)(() =>
            {
                DaysTillReleaseTextBlock.Text = output;
            }));
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // close the window
            Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // if mouse left button is clicked, allow dragging of the window
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}