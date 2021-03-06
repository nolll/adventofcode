﻿using System;
using System.Collections.Generic;
using System.Linq;
using Core.ShipPainting;

namespace ConsoleApp.Years.Year2019.Puzzles
{
    public class Day11 : Day2019
    {
        public Day11() : base(11)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var robot1 = new PaintRobot(FileInput);
            var result1 = robot1.Paint(false);

            return new PuzzleResult(result1.PaintedPanelCount, 1732);
        }

        public override PuzzleResult RunPart2()
        {
            var robot2 = new PaintRobot(FileInput);
            var result2 = robot2.Paint(true);
            var printout = CleanPrintout(result2.Printout);

            return new PuzzleResult(printout, CorrectAnswer);
        }

        private string CleanPrintout(string s)
        {
            var rows = s.Split("\r\n").ToList();
            var rowsWithOutput = new List<string>();

            foreach(var row in rows)
            {
                var chars = row.Trim().ToCharArray();
                if(!chars.All(o => o == '0'))
                {
                    rowsWithOutput.Add(row);
                }
            }

            var firstCharPos = rowsWithOutput.Min(o => o.IndexOf('1'));
            var lastCharPos = rowsWithOutput.Max(o => o.LastIndexOf('1'));
            var length = lastCharPos - firstCharPos + 1;
            var printoutRows = rowsWithOutput.Select(o => o.Substring(firstCharPos, length));
            return string.Join("\r\n", printoutRows).Replace('0', ' ').Replace('1', 'X'); ;
        }

        private const string CorrectAnswer = @" XX  XXX   XX  X    XXXX X  X X  X   XX
X  X X  X X  X X    X    X  X X  X    X
X  X XXX  X    X    XXX  X  X XXXX    X
XXXX X  X X    X    X    X  X X  X    X
X  X X  X X  X X    X    X  X X  X X  X
X  X XXX   XX  XXXX X     XX  X  X  XX ";
    }
}