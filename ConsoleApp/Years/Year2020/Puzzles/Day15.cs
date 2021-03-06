﻿using Core.ElfMemoryGame;

namespace ConsoleApp.Years.Year2020.Puzzles
{
    public class Day15 : Day2020
    {
        public Day15() : base(15)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var system = new MemoryGame(Input);
            var result = system.Play(2020);
            return new PuzzleResult(result, 1696);
        }

        public override PuzzleResult RunPart2()
        {
            var system = new MemoryGame(Input);
            var result = system.Play(30000000);
            return new PuzzleResult(result, 37_385);
        }

        private const string Input = "12,1,16,3,11,0";
    }
}