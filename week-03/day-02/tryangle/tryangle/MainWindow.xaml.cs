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

namespace tryangle
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
            DrawGreenLines(foxDraw);
        }
        public static void DrawGreenLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 350, 350, 350);
            foxDraw.DrawLine(175, 50, 350, 350);
            foxDraw.DrawLine(175, 50, 0, 350);
            for (int i = 0; i < 17; i++)
            {
                foxDraw.DrawLine(10+(i*10), 340-(i*18), 10+(i*20),350);
                foxDraw.DrawLine(350 - (i * 10), 340- (i * 18), 350- (i * 20), 350);
            }


        }
    }
}
