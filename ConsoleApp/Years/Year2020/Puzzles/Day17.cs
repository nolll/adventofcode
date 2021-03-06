﻿using Core.ExperimentalEnergySource;

namespace ConsoleApp.Years.Year2020.Puzzles
{
    public class Day17 : Day2020
    {
        public Day17() : base(17)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var cube = new ConwayCube();
            var result = cube.Boot3D(FileInput, 6);
            return new PuzzleResult(result, 382);
        }

        public override PuzzleResult RunPart2()
        {
            var cube = new ConwayCube();
            var result = cube.Boot4D(FileInput, 6);
            return new PuzzleResult(result, 2552);
        }
    }
}