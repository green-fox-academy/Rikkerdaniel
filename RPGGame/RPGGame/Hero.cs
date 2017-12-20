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

        public int Level { get; set; }
        public int CurentPlace { get; set; }
        // private foxDraw FoxDraw;
        private int CurrentX = 0;
        private int CurrentY = 0;
       public int CurrentTile = 0;
        
        private TileList tileList = new TileList();

        public void HeroUp(foxDraw FoxDraw)
        {
            if (CurrentY > 0 && tileList.Tilelist(CurrentTile - 10, FoxDraw.Level()) == 0)
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
            if (CurrentY < 500 && tileList.Tilelist(CurrentTile + 10, FoxDraw.Level()) == 0)
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
            if (CurrentX > 0 && tileList.Tilelist(CurrentTile - 1, FoxDraw.Level()) == 0)
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
            if (CurrentX < 450 && tileList.Tilelist(CurrentTile + 1, FoxDraw.Level()) == 0)
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