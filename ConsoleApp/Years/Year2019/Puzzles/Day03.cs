﻿using System;
using Core.IntersectionFinder;
using Core.Tools;

namespace ConsoleApp.Years.Year2019.Puzzles
{
    public class Day03 : Day2019
    {
        public Day03() : base(3)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var wirePaths = PuzzleInputReader.ReadLines(FileInput);
            var wirePathA = wirePaths[0];
            var wirePathB = wirePaths[1];

            var intersectionFinder = new IntersectionFinder(wirePathA, wirePathB);
            var distance = intersectionFinder.ClosestIntersection.Distance;
            return new PuzzleResult(distance, 865);
        }

        public override PuzzleResult RunPart2()
        {
            var wirePaths = PuzzleInputReader.ReadLines(FileInput);
            var wirePathA = wirePaths[0];
            var wirePathB = wirePaths[1];

            var intersectionFinder = new IntersectionFinder(wirePathA, wirePathB);
            var steps = intersectionFinder.FewestSteps.Steps;
            return new PuzzleResult(steps, 35_038);
        }
    }
}