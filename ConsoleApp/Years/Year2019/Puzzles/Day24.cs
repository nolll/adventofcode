﻿using System;
using Core.BugLife;

namespace ConsoleApp.Years.Year2019.Puzzles
{
    public class Day24 : Day2019
    {
        public Day24() : base(24)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var simulator = new BugLifeSimulator(FileInput);
            simulator.RunUntilRepeat();

            return new PuzzleResult(simulator.BiodiversityRating, 12_129_040);
        }

        public override PuzzleResult RunPart2()
        {
            var recursiveSimulator = new RecursiveBugLifeSimulator(FileInput);
            recursiveSimulator.Run(200);

            return new PuzzleResult(recursiveSimulator.BugCount, 2109);
        }
    }
}