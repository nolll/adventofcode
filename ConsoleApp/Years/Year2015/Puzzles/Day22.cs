﻿using System;
using Core.Tools;
using Core.WizardRpgSimulation;

namespace ConsoleApp.Years.Year2015.Puzzles
{
    public class Day22 : Day2015
    {
        public Day22() : base(22)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var p = GetParams();
            var simulator = new WizardRpgSimulator(WizardRpgGameMode.Easy);
            var leastManaRequiredToWinEasy = simulator.WinWithLowestCost(p.HitPoints, p.Damage);
            return new PuzzleResult(leastManaRequiredToWinEasy, 1824);
        }

        public override PuzzleResult RunPart2()
        {
            var p = GetParams();
            var simulator = new WizardRpgSimulator(WizardRpgGameMode.Hard);
            var leastManaRequiredToWinHard = simulator.WinWithLowestCost(p.HitPoints, p.Damage);
            return new PuzzleResult(leastManaRequiredToWinHard, 1937);
        }

        private Params GetParams()
        {
            var rows = PuzzleInputReader.ReadLines(FileInput);

            return new Params
            {
                HitPoints = GetIntFromRow(rows[0]),
                Damage = GetIntFromRow(rows[1])
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
        }
    }
}