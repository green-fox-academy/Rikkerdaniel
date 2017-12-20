using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    public class Game
    {
        private int CurrentX = 0;
        private int CurrentY = 0;
        private int CurrentTile = 0;
        private TileList tileList = new TileList();
        public void GameStart(foxDraw foxDraw)
        {
            var FoxDraw = foxDraw;
            var SkeletonsList = new List<Caracter>();

            Skeletons Skeleton1 = new Skeletons();
            Skeleton1.ATK = 2;
            Skeleton1.DEF = 2;
            
            SkeletonsList.Add(Skeleton1);
            Skeletons Skeleton2 = new Skeletons();
            Skeleton1.ATK = 2;
            Skeleton1.DEF = 2;
            
            SkeletonsList.Add(Skeleton2);
            Skeletons SkeletonWithKey = new Skeletons();
            Skeleton1.ATK = 2;
            Skeleton1.DEF = 2;
            
            SkeletonsList.Add(SkeletonWithKey);
            var mymap = new Map(FoxDraw);
            var boss = new Boss();
            mymap.MapCreater();
            boss.BossPlace(foxDraw);  
        }
        public void HeroUp(foxDraw FoxDraw)
        {
            if (CurrentY > 0 && tileList.Tilelist(CurrentTile - 10, FoxDraw.Level()) == 0)
            {
                FoxDraw.SetPosition(FoxDraw.Tiles[110], 1000, 1000);
                FoxDraw.SetPosition(FoxDraw.Tiles[111], 1000, 1000);
                FoxDraw.SetPosition(FoxDraw.Tiles[112], 1000, 1000);
                CurrentTile += -10;
                CurrentY += -50;
                FoxDraw.SetPosition(FoxDraw.Tiles[113], CurrentX, CurrentY);
            }
        }
        public void HeroDown(foxDraw FoxDraw)
        {
            if (CurrentY < 500 && tileList.Tilelist(CurrentTile + 10, FoxDraw.Level()) == 0)
            {
                FoxDraw.SetPosition(FoxDraw.Tiles[113], 1000, 1000);
                FoxDraw.SetPosition(FoxDraw.Tiles[111], 1000, 1000);
                FoxDraw.SetPosition(FoxDraw.Tiles[112], 1000, 1000);
                CurrentTile += 10;
                CurrentY += 50;
                FoxDraw.SetPosition(FoxDraw.Tiles[110], CurrentX, CurrentY);
            }
        }
        public void HeroLeft(foxDraw FoxDraw)
        {
            if (CurrentX > 0 && tileList.Tilelist(CurrentTile - 1, FoxDraw.Level()) == 0)
            {
                FoxDraw.SetPosition(FoxDraw.Tiles[110], 1000, 1000);
                FoxDraw.SetPosition(FoxDraw.Tiles[113], 1000, 1000);
                FoxDraw.SetPosition(FoxDraw.Tiles[112], 1000, 1000);
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
