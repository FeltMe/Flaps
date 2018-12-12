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
        Point Defoult_Green_point_1 = new Point(60, 60);
        //Point Defoult_Green_point_2 = new Point();
        //Point Defoult_Red_point_1 = new Point();
        //Point Defoult_Red_point_2 = new Point();
        //Point Defoult_Yellow_point_1 = new Point();
        //Point Defoult_Yellow_point_2 = new Point();
        //Point Defoult_Orange_point_1 = new Point();
        //Point Defoult_Orange_point_2 = new Point();

        Line line = new Line()
        {
            Fill = Brushes.Green,
            Stroke = Brushes.Black,
            StrokeThickness = 4
            
        };

        public Start()
        {
            InitializeComponent();
            //mp.Open(, UriKind.RelativeOrAbsolute);
            mp.Play();
        }

        private void Can_MouseMove(object sender, MouseEventArgs e)
        {
            line.X1 = 35;
            line.Y1 = 35;
            line.X2 = e.GetPosition(Can).X;
            line.Y2 = e.GetPosition(Can).Y;
            Can.Children.Remove(line);
            Can.Children.Add(line);
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            line.X1 = Defoult_Green_point_1.X;
            line.X2 = Defoult_Green_point_1.Y;
        }
        private void Ellipse_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
