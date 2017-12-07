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
           
            int starty = 330;
            int y = 0;
           

            DrawGreenLines(foxDraw, starty,y );

        }
        public static void DrawGreenLines(FoxDraw foxDraw, int x,int y)
        {
            if ( x>1)
            {
                foxDraw.DrawRectangle((x/3)+y , 0, x/3,x/3);
                foxDraw.DrawRectangle(((x/3)*2)+y, x/3 , x/3, x/3);

                DrawGreenLines(foxDraw, x/3,x/3);
            }
        }
    }
}

