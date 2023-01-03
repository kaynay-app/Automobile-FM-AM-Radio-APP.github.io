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
using System.Globalization;
using System.Windows.Threading;
using System.Timers;
using System.IO;
using static System.Console;

namespace Automobile_Radio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /* Name: Kelem Nyarko
     * Project: WPF.NET C#
     * App Name: Automobile FM/AM Radio APP
     */

    public partial class MainWindow : Window
    {
        DispatcherTimer CarTime = new DispatcherTimer();

        string line;
        string str;

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer CarTime = new DispatcherTimer();
            CarTime.Interval = TimeSpan.FromSeconds(1); //FromDays(7);
            CarTime.Tick += carTimer_Tick;
            CarTime.Start();

            lblCurrentDate.Content = DateTime.Now.ToLongTimeString(); 
            lblCurrentTime.Content = DateTime.Now.ToLongDateString(); 

        }

        private void carTimer_Tick(object? sender, EventArgs e)
        {
              DateTime dateTime = DateTime.Now;
              this.lblCurrentTime.Content = dateTime.ToString();
              CarTime.Start();
        }

        public async void btnPrev_Click(object sender, RoutedEventArgs e)
        {
              int lines = 4;
              try
              {
                  using (var sr = new StreamReader("FM Songs.txt"))
                  {
                    for (int i = 1; i <= lines; i++)
                      {
                          line = sr.ReadLine();
                      }

                    string[] songAbout = File.ReadAllLines(("FM Songs.txt"));             //str.Split(","); //Random.NextDouble();  
                    Random rand = new Random();
                    lblDisplaySinger.Content = songAbout[0];
                    lblDisplaySong.Content = songAbout[1];
                    Console.WriteLine(line[rand.Next(songAbout.Length)]);
                }
            }
              catch
              (Exception ex)
              {
                  // Let the user know what went wrong.
                  Console.WriteLine("The file could not be read:");

                  Console.WriteLine(ex.Message);
              } 
        }

        private void btnPreset1_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"NOW PLAYING: WMPG - {txtChannelText.Text}"); // \n
            //MessageBox.Show($"NOW PLAYING: WMPG - {txtChannelAMText.Text}");

            if (btnAM_FM.Content.Equals("FM"))
            {
                btnAM_FM.Content = "AM";
                MessageBox.Show($"NOW PLAYING: Preset 1 - {txtChannelAMText.Text} .00 \n Press {btnPreset1.Content} button again for FM");
            }
            else
            {
                btnAM_FM.Content = "FM";
                MessageBox.Show($"NOW PLAYING: WMPG - {txtChannelText.Text} \n Press {btnPreset1.Content} button again for AM");
                //txtChannelText.Text = "87.5";

            }

        }

        private void btnPreset2_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"NOW PLAYING: WHYY FM - {txtChannelText.Text}");

            if (btnAM_FM.Content.Equals("FM"))
            {
                btnAM_FM.Content = "AM";
                MessageBox.Show($"NOW PLAYING: Preset 2 - {txtChannelAMText.Text} .00 \n Press {btnPreset2.Content} button again for FM");
            }
            else
            {
                btnAM_FM.Content = "FM";
                MessageBox.Show($"NOW PLAYING: WHYY FM - {txtChannelText.Text} \n Press {btnPreset2.Content} button again for AM");
                //txtChannelText.Text = "87.5";

            }
        }

        private void btnPreset3_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"NOW PLAYING: WPEN - {txtChannelText.Text}");
            if (btnAM_FM.Content.Equals("FM"))
            {
                btnAM_FM.Content = "AM";
                MessageBox.Show($"NOW PLAYING: Preset 3 - {txtChannelAMText.Text} .00 \n Press {btnPreset3.Content} button again for FM");
            }
            else
            {
                btnAM_FM.Content = "FM";
                MessageBox.Show($"NOW PLAYING: WPEN FM - {txtChannelText.Text} \n Press {btnPreset3.Content} button again for AM");
                //txtChannelText.Text = "87.5";

            }
        }

        private void btnPreset4_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"NOW PLAYING: WBSS FM - {txtChannelText.Text}");
            if (btnAM_FM.Content.Equals("FM"))
            {
                btnAM_FM.Content = "AM";
                MessageBox.Show($"NOW PLAYING: Preset 4 - {txtChannelAMText.Text} .00 \n Press Preset  {btnPreset4.Content} button again for FM");
            }
            else
            {
                btnAM_FM.Content = "FM";
                MessageBox.Show($"NOW PLAYING: WBSS FM - {txtChannelText.Text} \n Press Preset {btnPreset4.Content} button again for AM");
                //txtChannelText.Text = "87.5";

            }
        }

        private void btnPreset5_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"NOW PLAYING: WIP FM - {txtChannelText.Text}");
            if (btnAM_FM.Content.Equals("FM"))
            {
                btnAM_FM.Content = "AM";
                MessageBox.Show($"NOW PLAYING: Preset 5 - {txtChannelAMText.Text} .00 \n Press {btnPreset5.Content} button again for FM");
            }
            else
            {
                btnAM_FM.Content = "FM";
                MessageBox.Show($"NOW PLAYING: WIP FM - {txtChannelText.Text} \n Press {btnPreset5.Content} button again for AM");
                //txtChannelText.Text = "87.5";

            }
        }

        private void btnPreset6_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"NOW PLAYING: THE FANATIC FM - {txtChannelText.Text}");
            if (btnAM_FM.Content.Equals("FM"))
            {
                btnAM_FM.Content = "AM";
                MessageBox.Show($"NOW PLAYING: Preset 6- {txtChannelAMText.Text} .00 \n Press {btnPreset6.Content} button again for FM");
            }
            else
            {
                btnAM_FM.Content = "FM";
                MessageBox.Show($"NOW PLAYING: THE FANATIC FM - {txtChannelText.Text} \n Press {btnPreset6.Content} button again for AM");
                //txtChannelText.Text = "87.5";

            }
        }

        private void btnPower_Click(object sender, RoutedEventArgs e)
        {

            if (btnPower.Content.Equals("POWER ON"))
            {
                btnPower.Content = "POWER OFF";
                lblFM.Visibility = Visibility.Hidden;
                lblDisplaySong.Visibility = Visibility.Hidden;
                imgVolume.Visibility = Visibility.Hidden;
                sldChannel.Visibility = Visibility.Hidden;
                sldChannelAM.Visibility = Visibility.Hidden;
                lblAM.Visibility = Visibility.Hidden;
                lblDisplaySinger.Visibility = Visibility.Hidden;
                lblDisplaySong.Visibility= Visibility.Hidden;
                txtChannelAMText.Visibility = Visibility.Hidden;
                txtChannelText.Visibility = Visibility.Hidden;
                lblSingerName.Visibility = Visibility.Hidden;
                lblsongName.Visibility = Visibility.Hidden;
                txtVolume.Text = "0";

            }
            else
            {
                btnPower.Content = "POWER ON";
                lblFM.Visibility = Visibility.Visible;
                lblDisplaySong.Visibility = Visibility.Visible;
                imgVolume.Visibility = Visibility.Visible;
                sldChannel.Visibility = Visibility.Visible;
                sldChannelAM.Visibility = Visibility.Visible;
                lblAM.Visibility = Visibility.Visible;
                lblDisplaySinger.Visibility = Visibility.Visible;
                lblDisplaySong.Visibility = Visibility.Visible;
                txtChannelAMText.Visibility = Visibility.Visible;
                txtChannelText.Visibility= Visibility.Visible;
                lblSingerName.Visibility = Visibility.Visible;
                lblsongName.Visibility = Visibility.Visible;
                txtChannelText.Text = txtChannelText.Text.ToString();

            }

            //lblFM.Visibility = Visibility.Hidden;
            //lblDisplaySong.Visibility = Visibility.Hidden;

        }

        private void btnAM_FM_Click(object sender, RoutedEventArgs e)
        {
            if (btnAM_FM.Content.Equals("FM"))
            {
                btnAM_FM.Content = "AM";
                lblFM.Visibility = Visibility.Hidden;
                lblAM.Visibility = Visibility.Visible;
                txtChannelAMText.Visibility = Visibility.Visible;
                sldChannel.Visibility = Visibility.Hidden;
                sldChannelAM.Visibility = Visibility.Visible;
                txtChannelText.Visibility = Visibility.Hidden;
            }
            else
            {
                btnAM_FM.Content = "FM";
                lblFM.Visibility = Visibility.Visible;
                lblAM.Visibility = Visibility.Hidden;
                sldChannel.Visibility = Visibility.Visible;
                sldChannelAM.Visibility = Visibility.Hidden;
                txtChannelText.Visibility = Visibility.Visible;
                txtChannelAMText.Visibility = Visibility.Hidden;
                //txtChannelText.Text = "87.5";

            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void sldVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
            if(sldVolume.Value == 70)
            {
                sldVolume.Background = Brushes.Orange;
                MessageBox.Show($"VOLUME LOUD");

            }
            if (sldVolume.Value >= 95)
            {
                sldVolume.Background = Brushes.Red;
                MessageBox.Show($"VOLUME TOO LOUD");

            }
            else
            {
                sldVolume.Background = Brushes.Yellow;
                //MessageBox.Show($"VOLUME MODERATE");
            }
        }
    }
}
