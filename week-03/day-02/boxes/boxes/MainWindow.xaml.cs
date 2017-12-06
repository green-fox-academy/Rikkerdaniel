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

namespace boxes
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            for (int i = 0; i < 4; i++)
            {
                DrawRectangle(foxDraw, i, 10 + (i * 35), 10 + (i * 35), 30, 30);
            }
        }
        public static void DrawRectangle(FoxDraw foxDraw, int col, double x, double y, double width, double hight)
        {
            int clr = col;
            if (clr == 0)
            {
                foxDraw.StrokeColor(Colors.Yellow);
                foxDraw.FillColor(Colors.Yellow);
                foxDraw.DrawRectangle(x, y, width, hight);
            }
            else if (clr == 1)
            {
                foxDraw.StrokeColor(Colors.Blue);
                foxDraw.FillColor(Colors.Blue);
                foxDraw.DrawRectangle(x, y, width, hight);
            }
            else if (clr == 2)
            {
                foxDraw.StrokeColor(Colors.Red);
                foxDraw.FillColor(Colors.Red);
                foxDraw.DrawRectangle(x, y, width, hight);
            }
            else if (clr == 3)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.FillColor(Colors.Green);
                foxDraw.DrawRectangle(x, y, width, hight);
            }

        }
    }
}
