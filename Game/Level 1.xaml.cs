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
        protected Polyline Green_polyline = new Polyline();
        protected Polyline Red_polyline = new Polyline();
        protected Polyline Yellow_polyline = new Polyline();
        protected Polyline Orange_polyline = new Polyline();

        public Start()
        {
            InitializeComponent();
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if((sender as Ellipse).Stroke == Brushes.Green)
            {
               //Green_polyline
            }
            else if ((sender as Ellipse).Stroke == Brushes.Red)
            {

            }
            else if ((sender as Ellipse).Stroke == Brushes.Yellow)
            {

            }
            else if ((sender as Ellipse).Stroke == Brushes.Orange)
            {

            }
        }
        
    }
}
