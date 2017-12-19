using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    class Hero : Caracter
    {
        public Hero()
        {
            FoxDraw.AddImage("Assets/hero-down.png", 0, 0);
            FoxDraw.AddImage("Assets/hero-left.png", 0, 0);
            FoxDraw.AddImage("Assets/hero-right.png", 0, 0);
            FoxDraw.AddImage("Assets/hero-up.png", 0, 0);
        }
        public int Level { get; set; }
        private foxDraw FoxDraw;
       private int CurrentX = 0;
        private int CurrentY = 0;
       private int CurrentTile = 0;
        public List<int> tilelist = new List<int> { 0, 0, 0, 1, 0, 1, 0, 0, 0, 0,
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


        public void HeroUp(foxDraw FoxDraw)
        {
            if (CurrentY > 0 && tilelist[CurrentTile - 10] == 0)
            {
                FoxDraw.SetPosition(FoxDraw.Tiles[0], 1000, 1000);
                FoxDraw.SetPosition(FoxDraw.Tiles[1], 1000, 1000);
                FoxDraw.SetPosition(FoxDraw.Tiles[2], 1000, 1000);
                CurrentTile += -10;
                CurrentY += -50;
                FoxDraw.SetPosition(FoxDraw.Tiles[3], CurrentX, CurrentY);
            }
        }
        public void HeroDown(foxDraw FoxDraw)
        {
            if (CurrentY < 500 && tilelist[CurrentTile + 10] == 0)
            {
                FoxDraw.SetPosition(FoxDraw.Tiles[3], 1000, 1000);
                FoxDraw.SetPosition(FoxDraw.Tiles[1], 1000, 1000);
                FoxDraw.SetPosition(FoxDraw.Tiles[2], 1000, 1000);
                CurrentTile += 10;
                CurrentY += 50;
                FoxDraw.SetPosition(FoxDraw.Tiles[0], CurrentX, CurrentY);
            }
        }
        public void HeroLeft(foxDraw FoxDraw)
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
        public void HeroRght(foxDraw FoxDraw)
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
