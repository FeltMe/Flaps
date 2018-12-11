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
    public partial class Start : Window
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Line line = new Line
            {
                X1 = 0,
                Y1 = 45,
                X2 = 90,
                Y2 = 45,
                Stroke = (sender as Ellipse).Stroke,
                StrokeThickness = 16

            };
            Grid.SetColumn(line, 3);
            Grid.SetRow(line, 4);
            MainGrid.Children.Add(line);
        }
    }
}
