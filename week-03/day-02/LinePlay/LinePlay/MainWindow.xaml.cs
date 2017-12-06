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

namespace LinePlay
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            LinesPlay(foxDraw);
        }
        public static void LinesPlay(FoxDraw foxDraw)
        {
            for (int i = 0; i < 9; i++)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(0, 40 + (i * 20), 40 + (i * 20), 200);
            }

            for (int i = 0; i < 9; i++)
            {
                foxDraw.StrokeColor(Colors.Purple);
                foxDraw.DrawLine(40 + (i * 20), 0, 200, 40 + (i * 20));
            }
        }
    }
}
