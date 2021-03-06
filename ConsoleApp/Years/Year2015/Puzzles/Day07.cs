﻿using Core.BitwiseLogic;

namespace ConsoleApp.Years.Year2015.Puzzles
{
    public class Day07 : Day2015
    {
        public Day07() : base(7)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var circuit = new Circuit(FileInput);
            var runOne = circuit.RunOne("a");
            return new PuzzleResult(runOne, 956);
        }

        public override PuzzleResult RunPart2()
        {
            var circuit = new Circuit(FileInput);
            var runTwo = circuit.RunTwo("a", "b");
            return new PuzzleResult(runTwo, 40_149);
        }
    }
}