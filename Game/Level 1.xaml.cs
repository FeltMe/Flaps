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
using System.Windows.Media;


namespace Game
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    /// 

    public partial class Start : Window
    {
        private MediaPlayer mp = new MediaPlayer();
        Point Defoult_Green_point_1 = new Point();
        Point Defoult_Green_point_2 = new Point();
        Point Defoult_Red_point_1 = new Point();
        Point Defoult_Red_point_2 = new Point();
        Point Defoult_Yellow_point_1 = new Point();
        Point Defoult_Yellow_point_2 = new Point();
        Point Defoult_Orange_point_1 = new Point();
        Point Defoult_Orange_point_2 = new Point();

        public Start()
        {
            InitializeComponent();
            //mp.Open(, UriKind.RelativeOrAbsolute);
            mp.Play();
        }

       //private void Ellipse_MouseDown(object sender, MouseEventArgs e)
       //{
       //
       //   // var elipse = (sender as Ellipse);
       //   // var l = Canvas.GetLeft(elipse);
       //   // var t = Canvas.GetTop(elipse);
       //   // var point1 = new Point(45, 45);
       //   // var point2 = new Point(90, 45);
       //   // Line line = new Line
       //   // {
       //   //     X1 = 45,
       //   //     X2 = 90,
       //   //     Y1 = 45,
       //   //     Y2 = 45
       //   // };
       //   // Canvas.SetLeft(line, l);
       //   // Canvas.SetTop(line, t);
       //   // line.Fill = Brushes.Black;
       //   // line.StrokeThickness = 6;
       //   // Can.Children.Add(line);
       //    
       //
       //
       //  
       //}

        private void Ellipse_MouseMove(object sender, MouseEventArgs e)
        {
            var elipse = (sender as Ellipse);
            Polyline polyline = new Polyline();
            Point first_point = new Point(e.GetPosition(elipse).X, e.GetPosition(elipse).Y);
            
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var elipse = (sender as Ellipse);
            var l = Canvas.GetLeft(elipse);
            var t = Canvas.GetTop(elipse);
            var point = new Point(45, 45);
            Polyline pol = new Polyline
            {
                Fill = Brushes.Green
            };
            Canvas.SetLeft(pol, l);
            Canvas.SetTop(pol, t);
            pol.Points.Add(point);
            pol.Points.Add(new Point(e.GetPosition(elipse).X, e.GetPosition(elipse).Y));
            pol.Points.Add(new Point(Mouse.GetPosition(sender as Ellipse).X, Mouse.GetPosition(sender as Ellipse).Y));
            pol.Fill = (sender as Ellipse).Fill;
            pol.Stroke = Brushes.Black;
            pol.StrokeThickness = 10;
            Can.Children.Add(pol);
        }
    }
}
