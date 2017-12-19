using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class TileList
    {
        public int Tilelist(int isThiszero,int level)
        {
            var tilelist = new List<int> {
             0, 0, 0, 1, 0, 1, 0, 0, 0, 0,
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

            var tilelist2 = new List<int> {
             0, 1, 0, 1, 0, 0, 0, 0, 0, 1,
             0, 1, 0, 0, 0, 0, 0, 1, 0, 0,
             0, 1, 1, 1, 0, 1, 0, 1, 1, 0,
             0, 0, 0, 0, 0, 1, 0, 0, 0, 0,
             1, 1, 0, 1, 1, 0, 0, 0, 1, 0,
             0, 0, 0, 1, 0, 0, 0, 0, 1, 0,
             0, 1, 0, 1, 0, 1, 1, 0, 1, 0,
             0, 1, 0, 0, 0, 1, 1, 0, 0, 0,
             0, 0, 1, 1, 0, 0, 0, 0, 1, 1,
             0, 0, 0, 0, 0, 0, 1, 0, 1, 0,
             0, 1, 0, 1, 0, 1, 0, 0, 0, 0};

            if (level==1)
            {

            return tilelist[isThiszero];
            }
            else 
            {
                return tilelist2[isThiszero];
            }
        }
    }
}
