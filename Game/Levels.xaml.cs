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
using System.Windows.Shapes;

namespace Game
{
    /// <summary>
    /// Interaction logic for Level.xaml
    /// </summary>
    public partial class Level : Window
    {
        public Level()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            new Start().ShowDialog(); 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            new Level_2().ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
            new Level_3().ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
            new Level_4().ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Close();
            new Level_5().ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.Close();
            new Level_6().ShowDialog();
        }
    }
}
