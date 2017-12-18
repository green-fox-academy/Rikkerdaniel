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
        public FoxDraw myfoxDraw { get; set; }

        public Map(FoxDraw foxDraw)
        {
            MapWidth = 10;
            MapHeigth = 11;
            myfoxDraw = foxDraw;
        }

        public void MapCreater()
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
            int ycoordinate = 0;
            int listcounter = 0;
            for (int i = 0; i < MapHeigth; i++)
            {
                int xcoordinate = 0;

                for (int j = 0; j < MapWidth; j++)
                {
                    if (tilelist[listcounter] == 0)
                    {
                        myfoxDraw.AddImage("Assets/floor.png", xcoordinate, ycoordinate);
                        xcoordinate = xcoordinate + 50;
                        
                        
                    }
                    if (tilelist [listcounter]==1)
                    {
                        myfoxDraw.AddImage("Assets/wall.png", xcoordinate, ycoordinate);
                        xcoordinate = xcoordinate + 50;
                       
                       
                    }
                    listcounter++;
                }
                ycoordinate = ycoordinate + 50;
            }
        }

    }
}
