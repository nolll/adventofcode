﻿using System;
using Core.BugLife;

namespace ConsoleApp.Years.Year2019
{
    public class Day24 : Day
    {
        public Day24() : base(24)
        {
        }

        protected override void RunDay()
        {
            WritePartTitle();
            var simulator = new BugLifeSimulator(Input);
            simulator.RunUntilRepeat();

            Console.WriteLine($"Biodiversity rating: {simulator.BiodiversityRating}");
        }

        private const string Input = @".#..#
#..##
##..#
##.##
#..##";
    }
}