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
using System.Windows.Media.Animation;
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



        private void Ellipse_MouseMove(object sender, MouseEventArgs e)
        {
            var elipse = (sender as Ellipse);
            var l = Canvas.GetLeft(elipse);
            var t = Canvas.GetTop(elipse);

            var point = new Point(e.GetPosition(elipse).X, e.GetPosition(elipse).Y);
            Polyline pol = new Polyline
            {
                Fill = Brushes.Green
            };
            Canvas.SetLeft(pol, l);
            Canvas.SetTop(pol, t);
            pol.Points.Add(point);
            pol.Points.Add(new Point(e.GetPosition(elipse).X, e.GetPosition(elipse).Y));
            pol.Points.Add(new Point(Mouse.GetPosition(sender as Ellipse).X + 32, Mouse.GetPosition(sender as Ellipse).Y + 32));
            pol.Fill = (sender as Ellipse).Fill;
            pol.Stroke = (sender as Ellipse).Fill;
            pol.StrokeThickness = 7;
            Can.Children.Add(pol);
        }
    }
}
