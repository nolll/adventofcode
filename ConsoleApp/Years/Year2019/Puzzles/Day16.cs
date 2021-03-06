﻿using System;
using Core.FlawedFrequencyTransmission;

namespace ConsoleApp.Years.Year2019.Puzzles
{
    public class Day16 : Day2019
    {
        public Day16() : base(16)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var algorithm1 = new FrequencyAlgorithmPart1(FileInput);
            var result1 = algorithm1.Run(100);

            return new PuzzleResult(result1, "19944447");
        }

        public override PuzzleResult RunPart2()
        {
            var algorithm2 = new FrequencyAlgorithmPart2(FileInput);
            var result2 = algorithm2.Run(100);

            return new PuzzleResult(result2, "81207421");
        }
    }
}