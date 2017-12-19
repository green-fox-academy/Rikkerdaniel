﻿using System;
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
        private foxDraw FoxDraw;
        private Hero hero = new Hero();
        public int ClicCounter=0;
        private Skeletons Skeleton1 = new Skeletons();
        private int Level = 0;

       


        public MainWindow()
        {
            Level++;

            InitializeComponent();
            var foxDraw = new foxDraw(canvas);
            
            var mymap = new Map(foxDraw);
            mymap.MapCreater();
            FoxDraw = new foxDraw(canvas);

            FoxDraw.AddImage("Assets/hero-down.png", 0, 0);
            FoxDraw.AddImage("Assets/hero-left.png", 0, 0);
            FoxDraw.AddImage("Assets/hero-right.png", 0, 0);
            FoxDraw.AddImage("Assets/hero-up.png", 0, 0);
            FoxDraw.AddImage("Assets/skeleton.png", 0, 0);
            FoxDraw.AddImage("Assets/skeleton.png", 0, 0);
            FoxDraw.AddImage("Assets/skeleton.png", 0, 0);
            FoxDraw.AddImage("Assets/boss.png", 0, 0);
            FoxDraw.AddImage("Assets/pixil-layer-Background (1).png", 0, 0);
            var skeleton = new Skeletons();
            skeleton.SkeletonPlace(FoxDraw);
            var boss = new Boss();
            boss.BossPlace(FoxDraw);

        }
        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                hero.HeroUp(FoxDraw);
            }
            if (e.Key == Key.Down)
            {
                hero.HeroDown(FoxDraw);
            }
            if (e.Key == Key.Left)
            {
                hero.HeroLeft(FoxDraw);
            }
            if (e.Key == Key.Right)
            {
                hero.HeroRght(FoxDraw);
            }
            ClicCounter++;
            if (ClicCounter%2==0)
            {
                Skeleton1.SkeletonMove(FoxDraw);
               
            }
            //if (hero current tile and monster current tile =)
            //{
            //    callll fight method
            //}
        }
    }
}