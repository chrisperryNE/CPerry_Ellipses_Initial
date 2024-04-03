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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CPerry_Ellipses
{
    
    public partial class MainWindow : Window
    {

        Random r = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Ellipse newEllipse = new Ellipse
            {
                Width = 50,
                Height = 50,
                StrokeThickness = 3,
                Stroke = Brushes.Black
            };

            Canvas.SetLeft(newEllipse, xslider.Value);
            Canvas.SetTop(newEllipse, r.Next(25, 425));

            canvas.Children.Add(newEllipse);

        }
    }
}
