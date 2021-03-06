﻿using System;
using Core.Computer;

namespace ConsoleApp.Years.Year2019.Puzzles
{
    public class Day02 : Day2019
    {
        public Day02() : base(2)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var computer = new ConsoleComputer(FileInput);
            computer.Start(false, 12, 2);
            var value = computer.Result;
            return new PuzzleResult(value, 3_101_844);
        }

        public override PuzzleResult RunPart2()
        {
            var solutionFinder = new ComputerSolutionFinder(FileInput);
            var result = solutionFinder.FindSolution(19690720);
            var answer = 100 * result.Noun + result.Verb;
            return new PuzzleResult(answer, 8478);
        }
    }
}