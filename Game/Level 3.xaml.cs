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
    /// Interaction logic for Level_3.xaml
    /// </summary>

    public partial class Level_3 : Window
    {
        MyLines line = new MyLines();
        DefoultObject df = new DefoultObject();
        private MediaPlayer _Level_3;

        public Level_3()
        {
            InitializeComponent();
            _Level_3 = new MediaPlayer();
            _Level_3.Open(new Uri("Media/Level_3.mp3", UriKind.RelativeOrAbsolute));
            _Level_3.Play();
        }

        private void Can_3_MouseMove(object sender, MouseEventArgs e)
        {
            if (line.line.X1 > 0 && line.line.Y1 > 0)
            {
                line.line.X2 = e.GetPosition(Can_3).X - 5;
                line.line.Y2 = e.GetPosition(Can_3).Y - 5;
                Can_3.Children.Remove(line.line);
                Can_3.Children.Add(line.line);
            }
        }

        private void Ellipse_3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            double Mouse_X = Mouse.GetPosition(Can_3).X;
            double Mouse_Y = Mouse.GetPosition(Can_3).Y;

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

        private void Ellipse_3_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Can_3.Children.Remove(line.line);
        }
        private void Ellipse_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            Line temp = new Line();
            temp.X1 = line.line.X1;
            temp.Y1 = line.line.Y2;
            temp.X2 = line.line.X2;
            temp.Y2 = line.line.Y2;
            temp.StrokeThickness = 4;
            temp.Fill = line.line.Fill;
            temp.Stroke = line.line.Stroke;
            Can_3.Children.Add(temp);
        }
    }
}