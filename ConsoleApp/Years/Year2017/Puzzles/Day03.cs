﻿using System;
using Core.SpiralMemory;

namespace ConsoleApp.Years.Year2017.Puzzles
{
    public class Day03 : Day2017
    {
        public Day03() : base(3)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var memory1 = new SpiralMemory(Input, SpiralMemoryMode.RunToTarget);
            return new PuzzleResult(memory1.Distance, 438);
        }

        public override PuzzleResult RunPart2()
        {
            var memory2 = new SpiralMemory(Input, SpiralMemoryMode.RunToValue);
            return new PuzzleResult(memory2.Value, 266_330);
        }

        private const int Input = 265149;
    }
}