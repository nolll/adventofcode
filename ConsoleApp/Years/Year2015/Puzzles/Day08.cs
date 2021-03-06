﻿using System;
using Core.SantasDigitalList;

namespace ConsoleApp.Years.Year2015.Puzzles
{
    public class Day08 : Day2015
    {
        public Day08() : base(8)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var digitalList = new DigitalList(FileInput);
            return new PuzzleResult(digitalList.CodeMinusMemoryDiff, 1342);
        }

        public override PuzzleResult RunPart2()
        {
            var digitalList = new DigitalList(FileInput);
            return new PuzzleResult(digitalList.EncodedMinusCodeDiff, 2074);
        }
    }
}