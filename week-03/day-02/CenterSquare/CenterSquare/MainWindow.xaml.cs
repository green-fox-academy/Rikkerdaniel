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

namespace CenterSquare
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
            foxDraw.BackgroundColor(Colors.Beige);
            DrawRectangle(foxDraw);
            // draw a green 10x10 square to the canvas' center.
        }
        public static void DrawRectangle(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Blue  );
            foxDraw.DrawRectangle(145,145, 10, 10);
        }
    }
}
