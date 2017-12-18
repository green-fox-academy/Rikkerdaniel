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

namespace RPGGame
{
    public partial class MainWindow : Window
    {
        private FoxDraw FoxDraw;
        private int CurrentX = 0;
        private int CurrentY = 0;
        private int CurrentTile = 0;

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            var mymap = new Map(foxDraw);

            mymap.MapCreater();

            FoxDraw = new FoxDraw(canvas);

            FoxDraw.AddImage("Assets/hero-down.png", 0, 0);
            FoxDraw.AddImage("Assets/hero-left.png", 0, 0);
            FoxDraw.AddImage("Assets/hero-right.png", 0, 0);
            FoxDraw.AddImage("Assets/hero-up.png", 0, 0);
        }
        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            var tilelist = new List<int> { 0, 0, 0, 1, 0, 1, 0, 0, 0, 0,
                                           0, 0, 0, 1, 0, 1 ,0 ,1 ,1 ,0,
                                           0, 1, 1, 1,0 , 1, 0 , 1, 1,0 ,
                                           0, 0, 0, 0, 0 ,1 , 0, 0, 0, 0,
                                           1, 1, 1, 1, 0, 1, 1 ,1 ,1 ,0,
                                           0, 1, 0, 1 ,0 ,0 ,0 , 0, 1 ,0,
                                           0, 1 , 0, 1, 0, 1, 1, 0, 1, 0,
                                           0, 0, 0, 0, 0, 1, 1, 0, 1, 0,
                                           0, 1, 1, 1, 0, 0, 0, 0, 1, 0,
                                           0, 0, 0, 1, 0, 1, 1, 0, 1, 0,
                                           0, 1, 0, 1, 0, 1, 0, 0, 0, 0};

            if (e.Key == Key.Up)
            {
                if (CurrentY  > 0 && tilelist[CurrentTile - 10] == 0)
                {
                    FoxDraw.SetPosition(FoxDraw.Tiles[0], 1000, 1000);
                    FoxDraw.SetPosition(FoxDraw.Tiles[1], 1000, 1000);
                    FoxDraw.SetPosition(FoxDraw.Tiles[2], 1000, 1000);
                    CurrentTile += -10;
                    CurrentY += -50;
                    FoxDraw.SetPosition(FoxDraw.Tiles[3], CurrentX, CurrentY);
                }
            }
            if (e.Key == Key.Down)
            {
                if (CurrentY < 500&&tilelist [CurrentTile+10 ]==0)
                {
                    FoxDraw.SetPosition(FoxDraw.Tiles[3], 1000, 1000);
                    FoxDraw.SetPosition(FoxDraw.Tiles[1], 1000, 1000);
                    FoxDraw.SetPosition(FoxDraw.Tiles[2], 1000, 1000);
                    CurrentTile += 10;
                    CurrentY += 50;
                    FoxDraw.SetPosition(FoxDraw.Tiles[0], CurrentX, CurrentY);
                }
            }
            if (e.Key == Key.Left)
            {
                if (CurrentX > 0 && tilelist[CurrentTile - 1] == 0)
                {
                    FoxDraw.SetPosition(FoxDraw.Tiles[0], 1000, 1000);
                    FoxDraw.SetPosition(FoxDraw.Tiles[3], 1000, 1000);
                    FoxDraw.SetPosition(FoxDraw.Tiles[2], 1000, 1000);
                    CurrentTile += -1;
                    CurrentX += -50;
                    FoxDraw.SetPosition(FoxDraw.Tiles[1], CurrentX, CurrentY);
                }
            }
            if (e.Key == Key.Right)
            {
                if (CurrentX < 450 && tilelist[CurrentTile + 1] == 0)
                {
                    FoxDraw.SetPosition(FoxDraw.Tiles[0], 1000, 1000);
                    FoxDraw.SetPosition(FoxDraw.Tiles[3], 1000, 1000);
                    FoxDraw.SetPosition(FoxDraw.Tiles[1], 1000, 1000);
                    CurrentTile += 1;
                    CurrentX += 50;
                    FoxDraw.SetPosition(FoxDraw.Tiles[2], CurrentX, CurrentY);
                }
            }
        }
    }
}
