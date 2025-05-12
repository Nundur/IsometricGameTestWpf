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

namespace IsometricGameTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gomb.Click += Gomb_Click;
        }

        private void Gomb_Click(object sender, RoutedEventArgs e)
        {
            //(new SolidColorBrush(Color.FromRgb(0, 0, 0)))
            //400, 300


            double x = 0;
            double y = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    x = ((i * 0.5 * 60) + (k * (-0.5) * 60)) +500;
                    y = ((i * 0.25 * 60) + (k * 0.25 * 60)) +300;

                    Image img = new Image();
                    img.Source = new BitmapImage(new Uri("tile.png", UriKind.Relative));
                    img.Height = 30;
                    img.Width = 60;
                    img.Opacity = 100;
                    img.Name = $"IMAGE_{i}_{k}";
                    Canvas.SetLeft(img, Convert.ToInt32(x));
                    Canvas.SetTop(img, Convert.ToInt32(y));
                    azEnCanvasom.Children.Add(img);

                    TextBlock txtB = new TextBlock();
                    txtB.Text = $"{i}_{k}";


                    Canvas.SetLeft(txtB, Convert.ToInt32(x));
                    Canvas.SetTop(txtB, Convert.ToInt32(y));
                    azEnCanvasom.Children.Add(txtB);






                }
            }
        }
    }
}
