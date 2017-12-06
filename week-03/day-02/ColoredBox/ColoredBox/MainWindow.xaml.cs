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

namespace ColoredBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawGreenLines(foxDraw);

        }
        public static void DrawGreenLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(10, 0, 100, 0);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(100, 0, 100, 100);
            foxDraw.StrokeColor(Colors.Orange);
            foxDraw.DrawLine(100, 100, 10, 100);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(10, 100, 10, 0);

        }
    }
}
