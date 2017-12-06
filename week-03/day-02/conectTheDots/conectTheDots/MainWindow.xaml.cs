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

namespace conectTheDots
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
            var dotlist = new List<Point>();
            dotlist.Add(new Point(10, 10));
            dotlist.Add(new Point(290, 10));
            dotlist.Add(new Point(290, 290));
            dotlist.Add(new Point(10, 290));

            var dotlist1 = new List<Point>();
            dotlist1.Add(new Point(50, 100));
            dotlist1.Add(new Point(70, 70));
            dotlist1.Add(new Point(80, 90));
            dotlist1.Add(new Point(100, 70));
            dotlist1.Add(new Point(120, 100));
            dotlist1.Add(new Point(85, 130));
            dotlist1.Add(new Point(50, 100));


            ConectDots(foxDraw, dotlist);
            ConectDots2(foxDraw, dotlist1);
        }
        public static void ConectDots(FoxDraw foxDraw, List<Point> list)
        {
            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawPolygon(list );
        }

        public static void ConectDots2(FoxDraw foxDraw, List<Point> list1)
        {
            foxDraw.FillColor(Colors.Yellow);
            foxDraw.StrokeColor(Colors.Yellow);
            foxDraw.DrawPolygon(list1);
        }
        

    }
}
