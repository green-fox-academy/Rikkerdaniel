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

namespace fractal
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawGreenLines(foxDraw, 300, 0, 0, 300);
        }
        public static void DrawGreenLines(FoxDraw foxDraw, int a, int b, int c, int d)
        {
            if (a == 300)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(b, c, a, b);
                foxDraw.DrawLine(b, c, a / 2, a);
                foxDraw.DrawLine(a, c, a / 2, a);
                DrawGreenLines(foxDraw, a / 2, a / 4, 0,d );

            }
            if (a < 300 && a > 1)
            {
                foxDraw.DrawLine(a, c, a / 2, a); //ez jo 
                foxDraw.DrawLine(a / 2, a, (a / 2) * 3, a);
                foxDraw.DrawLine(a, c, (a / 2) * 3, a);
               
                foxDraw.DrawLine(d - (a / 2), c, d - (a / 4), a / 2);
                foxDraw.DrawLine(d - (a / 2), c,d-(3*(a/4)) ,a/2);
                foxDraw.DrawLine(d-(3*(a/4)) ,a/2, d - (a / 4), a / 2);

                foxDraw.DrawLine(d/2, d-a,(d/2)+(a/4), d - (a / 2));
                foxDraw.DrawLine(d/2, d-a, (d / 2) - (a / 4), d - (a / 2));
                foxDraw.DrawLine((d / 2) - (a / 4), d - (a / 2), (d/2)+(a/4), d - (a / 2));



                DrawGreenLines(foxDraw, a/2, a/2, 0, 300);
                DrawGreenLines(foxDraw, a / 2, a / 4, 0, 300);

            }

        }
    }
}
