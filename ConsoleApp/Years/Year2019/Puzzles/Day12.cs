﻿using System;
using Core.MoonTracking;

namespace ConsoleApp.Years.Year2019.Puzzles
{
    public class Day12 : Day2019
    {
        public Day12() : base(12)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var tracker1 = new MoonTracker(FileInput);
            const int iterations = 1000;
            tracker1.Run(iterations);

            return new PuzzleResult(tracker1.TotalEnergy, 7471);
        }

        public override PuzzleResult RunPart2()
        {
            var tracker2 = new MoonTracker(FileInput);
            tracker2.RunUntilRepeat();

            return new PuzzleResult(tracker2.Iterations, 376_243_355_967_784);
        }
    }
}