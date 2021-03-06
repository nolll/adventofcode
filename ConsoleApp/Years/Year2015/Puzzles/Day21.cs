﻿using System;
using Core.RpgSimulation;
using Core.Tools;

namespace ConsoleApp.Years.Year2015.Puzzles
{
    public class Day21 : Day2015
    {
        public Day21() : base(21)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var p = GetParams();
            var simulator = new RpgSimulator();
            var leastGoldRequiredToWin = simulator.WinWithLowestCost(p.HitPoints, p.Damage, p.Armor);
            return new PuzzleResult(leastGoldRequiredToWin, 78);
        }

        public override PuzzleResult RunPart2()
        {
            var p = GetParams();
            var simulator = new RpgSimulator();
            var mostGoldThatLoses = simulator.LoseWithHighestCost(p.HitPoints, p.Damage, p.Armor);
            return new PuzzleResult(mostGoldThatLoses, 148);
        }

        private Params GetParams()
        {
            var rows = PuzzleInputReader.ReadLines(FileInput);

            return new Params
            {
                HitPoints = GetIntFromRow(rows[0]),
                Damage = GetIntFromRow(rows[1]),
                Armor = GetIntFromRow(rows[2])
            };
        }

        private static int GetIntFromRow(string s)
        {
            return int.Parse(s.Split(':')[1].Trim());
        }

        private class Params
        {
            public int HitPoints { get; set; }
            public int Damage { get; set; }
            public int Armor { get; set; }
        }
    }
}