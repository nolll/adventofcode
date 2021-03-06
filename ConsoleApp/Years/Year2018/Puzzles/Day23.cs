﻿using System;
using Core.ExperimentalEmergencyTeleportation;

namespace ConsoleApp.Years.Year2018.Puzzles
{
    public class Day23 : Day2018
    {
        public Day23() : base(23)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var formation = new NanobotFormation(FileInput);
            var botCount = formation.GetBotsInRangeOfStrongestBot().Count;
            return new PuzzleResult(botCount, 481);
        }

        public override PuzzleResult RunPart2()
        {
            var formation = new NanobotFormation(FileInput);
            var distanceToBestCoords = formation.FindManhattanDistanceToBestCoords();
            return new PuzzleResult(distanceToBestCoords, 47_141_479);
        }
    }
}