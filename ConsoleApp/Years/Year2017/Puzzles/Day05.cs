﻿using System;
using Core.JumpInstructions;

namespace ConsoleApp.Years.Year2017.Puzzles
{
    public class Day05 : Day2017
    {
        public Day05() : base(5)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var jumper1 = new InstructionJumper(FileInput);
            jumper1.Start1();
            return new PuzzleResult(jumper1.StepCount, 387_096);
        }

        public override PuzzleResult RunPart2()
        {
            var jumper2 = new InstructionJumper(FileInput);
            jumper2.Start2();
            return new PuzzleResult(jumper2.StepCount, 28_040_648);
        }
    }
}