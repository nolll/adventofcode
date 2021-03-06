﻿using System;
using Core.SantasRoute;

namespace ConsoleApp.Years.Year2015.Puzzles
{
    public class Day09 : Day2015
    {
        public Day09() : base(9)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var calculator = new RouteCalculator(FileInput);
            return new PuzzleResult(calculator.ShortestDistance, 117);
        }

        public override PuzzleResult RunPart2()
        {
            var calculator = new RouteCalculator(FileInput);
            return new PuzzleResult(calculator.LongestDistance, 909);
        }
    }
}