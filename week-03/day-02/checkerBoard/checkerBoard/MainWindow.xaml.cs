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
using GreenFox;

namespace checkerBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawRectangle(foxDraw);
            
        }
        public static void DrawRectangle(FoxDraw foxDraw)
        {

            double horizontal = 0;
            double vertical = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    foxDraw.StrokeColor(Colors.Black);
                    foxDraw.FillColor(Colors.Black);
                    foxDraw.DrawRectangle(horizontal, vertical, 10, 10);
                    horizontal += 20;
                }
                vertical += 10;
                horizontal = 10;
                for (int k = 0; k < 4; k++)
                {
                    foxDraw.StrokeColor(Colors.Black);
                    foxDraw.FillColor(Colors.Black);
                    foxDraw.DrawRectangle(horizontal, vertical, 10, 10);
                    horizontal += 20;
                }

                horizontal = 0;
                vertical += 10;
            }
        }
    }
}
