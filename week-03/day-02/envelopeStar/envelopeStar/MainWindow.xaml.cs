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

namespace envelopeStar
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
            EnvelopeStar(foxDraw);
        }
        public static void EnvelopeStar(FoxDraw foxDraw)
        {
            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.Blue);
                foxDraw.DrawLine(0 + (i * 10), 100, 100, 100 - (i * 10));
                foxDraw.DrawLine(0 + (i * 10), 100, 100, 100 + (i * 10));
                foxDraw.DrawLine(200 - (i * 10), 100, 100, 100 - (i * 10));
                foxDraw.DrawLine(200 - (i * 10), 100, 100, 100 + (i * 10));
            }
        }
    }
}
