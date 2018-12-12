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
    /// Interaction logic for Start.xaml
    /// </summary>
    /// 

    public partial class Start : Window
    {
        public Start()
        {
            InitializeComponent();

        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var kek = (sender as Canvas);
            
            var temp = new Point(35, 30);
            Polyline pol = new Polyline();
            pol.Fill = Brushes.Green;
            pol.Points.Add(temp);
            pol.Points.Add(new Point(temp.X + 45, temp.Y));
            //pol.Points.Add(new Point(Mouse.GetPosition(sender as Ellipse).X + 32, Mouse.GetPosition(sender as Ellipse).Y + 32));
            pol.Fill = (sender as Ellipse).Fill;
            pol.Stroke = (sender as Ellipse).Stroke;
            pol.StrokeThickness = 7;
            Can.Children.Add(pol);
            //Ellipse_MouseUp(sender, e);
        }

        private void Ellipse_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Test");
        }
    }
}
