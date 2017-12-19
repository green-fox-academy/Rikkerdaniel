using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    class Skeletons : Caracter
    {
        public int Level { get; set; }
        private foxDraw FoxDraw;
        private int SkeletonX1 = 0;
        private int SkeletonY1 = 0;
        private int Skeleton1CurrentTile = 0;
        private int SkeletonX2 = 0;
        private int SkeletonY2 = 0;
        private int Skeleton2CurrentTile = 0;
        private int SkeletonX3 = 0;
        private int SkeletonY3 = 0;
        private int Skeleton3CurrentTile = 0;
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
        

            public Random random = new Random();
        public void SkeletonPlace(foxDraw FoxDraw)
        {
            
            int skeleton1 = random.Next(1, 109);


            int skeleton2 = random.Next(1, 109);


            int skeleton3 = random.Next(1, 109);
            
            Skeleton1CurrentTile = skeleton1;
            SkeletonX1 = skeleton1 % 10;
            SkeletonY1 = skeleton1 / 10;
            Skeleton2CurrentTile = skeleton2;
            SkeletonX2 = skeleton2 % 10;
            SkeletonY2 = skeleton2 / 10;
            Skeleton3CurrentTile = skeleton3;
            SkeletonX3 = skeleton3 % 10;
            SkeletonY3 = skeleton3 / 10;
            if (tilelist[Skeleton1CurrentTile] == 1 || tilelist[Skeleton2CurrentTile] == 1 || tilelist[Skeleton3CurrentTile] == 1)
            {
                SkeletonPlace(FoxDraw);
            }
            else
            {
            FoxDraw.SetPosition(FoxDraw.Tiles[4], SkeletonX1 * 50, SkeletonY1 * 50);
            FoxDraw.SetPosition(FoxDraw.Tiles[5], SkeletonX2 * 50, SkeletonY2 * 50);
            FoxDraw.SetPosition(FoxDraw.Tiles[6], SkeletonX3 * 50, SkeletonY3 * 50);

            }
        }
    }
}
