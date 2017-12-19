using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    class Map
    {
        public int MapWidth { get; private set; }
        public int MapHeigth { get; private set; }
        public foxDraw FoxDraw { get; set; }

        public Map(foxDraw foxDraw)
        {
            MapWidth = 10;
            MapHeigth = 11;
            FoxDraw = foxDraw;
        }

         private TileList tileList = new TileList();
        public void MapCreater()
        {
            int ycoordinate = 0;
            int listcounter = 0;
            for (int i = 0; i < MapHeigth; i++)
            {
                int xcoordinate = 0;

                for (int j = 0; j < MapWidth; j++)
                {
                    if (tileList.Tilelist(listcounter, FoxDraw.Level()) == 0)
                    {
                        FoxDraw.AddImage("Assets/floor.png", xcoordinate, ycoordinate);
                        xcoordinate = xcoordinate + 50;
                    }
                    if (tileList.Tilelist(listcounter, FoxDraw.Level()) == 1)
                    {
                        FoxDraw.AddImage("Assets/wall.png", xcoordinate, ycoordinate);
                        xcoordinate = xcoordinate + 50;
                    }
                    listcounter++;
                }
                ycoordinate = ycoordinate + 50;
            }
        }

    }
}
