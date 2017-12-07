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

namespace SquareinSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.Yellow);
            int startx = 0;
            int starty = 110;
            int endx = 330;
            int endy = 110;

            DrawGreenLines(foxDraw, startx, starty, endx, endy);

        }
        public static void DrawGreenLines(FoxDraw foxDraw, int x, int y, int x1, int y1)
        {
            if (y > 10)
            {
                foxDraw.DrawLine(x, y, x1, y1);
                foxDraw.DrawLine(x, y * 2, x1, y1 * 2);

                DrawGreenLines(foxDraw, x + (x1 / 3), y / 3, (x1 / 3) * 2, y1 / 3);
            }
        }
    }
}

