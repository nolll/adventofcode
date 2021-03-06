﻿using System;
using Core.SpringDroidAdventure;

namespace ConsoleApp.Years.Year2019.Puzzles
{
    public class Day21 : Day2019
    {
        public Day21() : base(21)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var walkingDroid = new SpringDroid(FileInput, WalkProgram);
            walkingDroid.Run();
            return new PuzzleResult(walkingDroid.HullDamage, 19_362_822);
        }

        public override PuzzleResult RunPart2()
        {
            var runningDroid = new SpringDroid(FileInput, RunProgram);
            runningDroid.Run();
            return new PuzzleResult(runningDroid.HullDamage, 1_143_625_214);
        }

        private const string WalkProgram = @"
OR A T
AND B T
AND C T
NOT T J
AND D J
WALK";

        private const string RunProgram = @"
OR A T
AND B T
AND C T
NOT T J
OR E T
OR H T
AND T J
AND D J
RUN";
    }
}