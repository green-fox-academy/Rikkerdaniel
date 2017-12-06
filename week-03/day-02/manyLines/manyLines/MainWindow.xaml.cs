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

namespace manyLines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawLines(foxDraw);
        }
        public static void DrawLines(FoxDraw foxDraw)
        {
            for (int i = 0; i < 11; i++)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(0 + (i * 20), 0, 100, 100);
                foxDraw.DrawLine(200, 0 + (i * 20), 100, 100);
                foxDraw.DrawLine(0, 0 + (i * 20), 100, 100);
                foxDraw.DrawLine(0 + (i * 20), 200, 100, 100);

            }
        }
    }
}
