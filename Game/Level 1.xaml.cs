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


        private MediaPlayer mp = new MediaPlayer();
        Point Defoult_Green_point_1 = new Point(315, 387);
        Point Defoult_Green_point_2 = new Point(192, 377);
        Point Defoult_Red_point_1 = new Point(270, 35);
        Point Defoult_Red_point_2 = new Point(315, 157);
        Point Defoult_Yellow_point_1 = new Point(270, 95);
        Point Defoult_Yellow_point_2 = new Point(192, 235);
        Point Defoult_Orange_point_1 = new Point(350, 34);
        Point Defoult_Orange_point_2 = new Point(315, 235);
        Point Defoult_Blue_point_1 = new Point(38, 35);
        Point Defoult_Blue_point_2 = new Point(157, 377);

        Line line = new Line()
        {
            Fill = Brushes.Green,
            Stroke = Brushes.Black,
            StrokeThickness = 4,
        };

        public Start()
        {
            InitializeComponent();
            //mp.Open(, UriKind.RelativeOrAbsolute);
            mp.Play();
        }

        private void Can_MouseMove(object sender, MouseEventArgs e)
        {
            if (line.X1 > 0 && line.Y1 > 0)
            {
                line.X2 = e.GetPosition(Can).X - 5;
                line.Y2 = e.GetPosition(Can).Y - 5;
                Can.Children.Remove(line);
                Can.Children.Add(line);
            }
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            double Mouse_X = Mouse.GetPosition(Can).X;
            double Mouse_Y = Mouse.GetPosition(Can).Y;
            line.Stroke = (sender as Ellipse).Stroke;
            line.Fill = (sender as Ellipse).Fill;

            if (Mouse_X > 0 && Mouse_X < 65 && Mouse_Y > 0 && Mouse_Y < 55)
            {
                line.X1 = Defoult_Blue_point_1.X;
                line.Y1 = Defoult_Blue_point_1.Y;
            }
            else if (Mouse_X > 248 && Mouse_X < 320 && Mouse_Y > 0 && Mouse_Y < 55)
            {
                line.X1 = Defoult_Red_point_1.X;
                line.Y1 = Defoult_Red_point_1.Y;
            }
            else if (Mouse_X > 248 && Mouse_X < 320 && Mouse_Y > 70 && Mouse_Y < 125)
            {
                line.X1 = Defoult_Yellow_point_1.X;
                line.Y1 = Defoult_Yellow_point_1.Y;
            }
            else if (Mouse_X > 320 && Mouse_X < 400 && Mouse_Y > 0 && Mouse_Y < 55)
            {
                line.X1 = Defoult_Orange_point_1.X;
                line.Y1 = Defoult_Orange_point_1.Y;
            }
        }
        private void Ellipse_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Ellipse_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Can.Children.Remove(line);
        }
    }
}
