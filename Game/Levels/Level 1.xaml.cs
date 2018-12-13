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
        MyLines line = new MyLines();
        DefoultObject df = new DefoultObject();
        private MediaPlayer mp = new MediaPlayer();

        public Start()
        {
            InitializeComponent();
            //mp.Open(, UriKind.RelativeOrAbsolute);

            BitmapImage b = new BitmapImage(new Uri("Pictures/Level_1.jpg", UriKind.Relative));

            ImageBrush ib = new ImageBrush();

            ib.ImageSource = b;
            this.Background = ib;
            mp.Play();
        }

        private void Can_MouseMove(object sender, MouseEventArgs e)
        {
            if (line.line.X1 > 0 && line.line.Y1 > 0)
            {
                line.line.X2 = e.GetPosition(Can).X - 4;
                line.line.Y2 = e.GetPosition(Can).Y - 4;
                Can.Children.Remove(line.line);
                Can.Children.Add(line.line);
            }
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            double Mouse_X = Mouse.GetPosition(Can).X;
            double Mouse_Y = Mouse.GetPosition(Can).Y;
            line.line.Stroke = (sender as Ellipse).Stroke;
            line.line.Fill = (sender as Ellipse).Fill;

            if (Mouse_X > 0 && Mouse_X < 65 && Mouse_Y > 0 && Mouse_Y < 55)
            {
                line.line.X1 = df.Defoult_Blue_point_1.X;
                line.line.Y1 = df.Defoult_Blue_point_1.Y;
            }
            else if (Mouse_X > 248 && Mouse_X < 320 && Mouse_Y > 0 && Mouse_Y < 55)
            {
                line.line.X1 = df.Defoult_Red_point_1.X;
                line.line.Y1 = df.Defoult_Red_point_1.Y;
            }
            else if (Mouse_X > 248 && Mouse_X < 320 && Mouse_Y > 70 && Mouse_Y < 125)
            {
                line.line.X1 = df.Defoult_Yellow_point_1.X;
                line.line.Y1 = df.Defoult_Yellow_point_1.Y;
            }
            else if (Mouse_X > 320 && Mouse_X < 400 && Mouse_Y > 0 && Mouse_Y < 55)
            {
                line.line.X1 = df.Defoult_Orange_point_1.X;
                line.line.Y1 = df.Defoult_Orange_point_1.Y;
            }
            else if (Mouse_X > 120 && Mouse_X < 220 && Mouse_Y > 125 && Mouse_Y < 180)
            {
                line.line.X1 = df.Defoult_Yellow_point_2.X;
                line.line.Y1 = df.Defoult_Yellow_point_2.Y;
            }
            else if (Mouse_X > 90 && Mouse_X < 145 && Mouse_Y > 260 && Mouse_Y < 315)
            {
                line.line.X1 = df.Defoult_Red_point_2.X;
                line.line.Y1 = df.Defoult_Red_point_2.Y;
            }
            else if (Mouse_X > 165 && Mouse_X < 220 && Mouse_Y > 260 && Mouse_Y < 315)
            {
                line.line.X1 = df.Defoult_Orange_point_2.X;
                line.line.Y1 = df.Defoult_Orange_point_2.Y;
            }
            else if (Mouse_X > 320 && Mouse_X < 400 && Mouse_Y > 260 && Mouse_Y < 315)
            {
                line.line.X1 = df.Defoult_Green_point_1.X;
                line.line.Y1 = df.Defoult_Green_point_1.Y;
            }
            else if (Mouse_X > 90 && Mouse_X < 145 && Mouse_Y > 320 && Mouse_Y < 400)
            {
                line.line.X1 = df.Defoult_Blue_point_2.X;
                line.line.Y1 = df.Defoult_Blue_point_2.Y;
            }
            else if (Mouse_X > 165 && Mouse_X < 220 && Mouse_Y > 320 && Mouse_Y < 400)
            {
                line.line.X1 = df.Defoult_Green_point_2.X;
                line.line.Y1 = df.Defoult_Green_point_2.Y;
            }

        }
        private void Ellipse_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Can.Children.Remove(line.line);
        }

        private void Ellipse_MouseDown_1(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
