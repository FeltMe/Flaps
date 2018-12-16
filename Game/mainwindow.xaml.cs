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

namespace Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MediaPlayer _Start;
        // public MediaPlayer _StartSound;

        public MainWindow()
        {
            InitializeComponent();
            _Start = new MediaPlayer();
            //  _StartSound = new MediaPlayer();
            _Start.Open(new Uri("Media/Start.mp3", UriKind.RelativeOrAbsolute));
            _Start.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.Visibility = Visibility.Hidden;
            new Start().ShowDialog();

            this.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _Start.Close();
            this.Visibility = Visibility.Hidden;
            //_Start.Pause();
            new Level().ShowDialog();
            this.Visibility = Visibility.Visible;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            _Start.Pause();
            new Help().ShowDialog();
            this.Visibility = Visibility.Visible;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //  _Start.Open(new Uri("Media/Start.mp3", UriKind.RelativeOrAbsolute));
            _Start.Pause();
            // Button_Click_5=this.Visibility = Visibility.Hidden;

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility;
            _Start.Play();
        }
    }
}
