using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    class Boss
    {
        //private foxDraw FoxDraw;
        private int BossX1 = 0;
        private int BossY1 = 0;
        private int BossCurrentTile = 0;
        private TileList tileList = new TileList();

        public void BossPlace(foxDraw FoxDraw)
        {
            var random = new Random();
            int bossPlace = random.Next(1, 109);

            BossCurrentTile = bossPlace;
            BossX1 = bossPlace % 10;
            BossY1 = bossPlace / 10;
            if (tileList.Tilelist(BossCurrentTile,FoxDraw.Level()) == 1 )
            {
                BossPlace(FoxDraw);
            }
            else
            {
                FoxDraw.SetPosition(FoxDraw.Tiles[7], BossX1  * 50, BossY1 * 50);
            }
        }
    }
}
