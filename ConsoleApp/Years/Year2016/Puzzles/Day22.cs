﻿using System;
using Core.GridComputing;

namespace ConsoleApp.Years.Year2016.Puzzles
{
    public class Day22 : Day2016
    {
        public Day22() : base(22)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var storageGrid = new StorageGrid(FileInput);
            var pairCount = storageGrid.GetViablePairCount();
            return new PuzzleResult(pairCount, 950);
        }

        public override PuzzleResult RunPart2()
        {
            var storageGrid = new StorageGrid(FileInput);
            var moveCount = storageGrid.MoveStorage();
            return new PuzzleResult(moveCount, 256);
        }
    }
}