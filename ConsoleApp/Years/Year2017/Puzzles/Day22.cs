﻿using System;
using Core.SporificaVirus;

namespace ConsoleApp.Years.Year2017.Puzzles
{
    public class Day22 : Day2017
    {
        public Day22() : base(22)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var infection1 = new VirusInfection(FileInput);
            var infectionCount1 = infection1.RunPart1(10_000);
            return new PuzzleResult(infectionCount1, 5538);
        }

        public override PuzzleResult RunPart2()
        {
            var infection2 = new VirusInfection(FileInput);
            var infectionCount2 = infection2.RunPart2(10_000_000);
            return new PuzzleResult(infectionCount2, 2_511_090);
        }
    }
}