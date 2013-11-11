using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RandomNumberGenerator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (!isValid(s_lower.Text))
            {

                var messageDialog2 = new MessageDialog("Please enter a value");
                await messageDialog2.ShowAsync();

            }

            else
            {

                try
                {




                    Random rnd = new Random();
                    int lower = System.Convert.ToInt32(s_lower.Text);
                    int higher = System.Convert.ToInt32(s_higher.Text);



                    int number = rnd.Next(lower, higher); // creates a number between 1 and 100
                    string s_number = number.ToString();
                    Result.Text = s_number;

                }


                catch (Exception ex)
                {

                    message_user("Please enter a valid value");


                }



            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {

            var messageDialog2 = new MessageDialog("This app generates numbers between two specified values");
            await messageDialog2.ShowAsync();

        }

            private async void message_user(string thingy)
        {
            var messageDialog3 = new MessageDialog(thingy);
            await messageDialog3.ShowAsync();

            }

        private Boolean isValid(string doofer)
        {

            if (doofer == "")
            {

                return false;

            }

            else 

            return true;


            
        }


        
    }
}
