﻿using System;
using Core.DominoBridge;

namespace ConsoleApp.Years.Year2017.Puzzles
{
    public class Day24 : Day2017
    {
        public Day24() : base(24)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var builder1 = new BridgeBuilder(FileInput, false);
            var bridge1 = builder1.Build();
            return new PuzzleResult(bridge1.Strength, 1940);
        }

        public override PuzzleResult RunPart2()
        {
            var builder2 = new BridgeBuilder(FileInput, true);
            var bridge2 = builder2.Build();
            return new PuzzleResult(bridge2.Strength, 1928);
        }
    }
}