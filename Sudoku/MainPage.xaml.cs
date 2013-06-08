using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Sudoku
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private DispatcherTimer timer;
        int second = 0;
        int minute = 0;
        public MainPage()
        {
            this.InitializeComponent();
            StartTimer();
        }
        private void StartTimer()
        {
            if (this.timer != null)
            {
                this.StopTimer();
            }
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 1);
            timer.Tick += timer_Tick;
            timer.Start();

        }

        private void StopTimer()
        {
            if (this.timer != null)
            {
                this.timer.Stop();
                this.timer = null;
            }
        }


        void timer_Tick(object sender, object e)
        {
            second++;
            if (second == 60)
            {
                minute++;
                second = 0;
            }
            timerTextBlock.Text = minute.ToString()+ " : "+second.ToString();
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        private void box00_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void box00_GotFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            box00.BorderThickness = new Thickness(2);
        }
    }
}
