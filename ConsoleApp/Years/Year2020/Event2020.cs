﻿using System.Collections.Generic;
using ConsoleApp.Years.Year2020.Puzzles;


namespace ConsoleApp.Years.Year2020
{
    public class Event2020 : Event
    {
        public Event2020() : base(2020)
        {
        }

        public override IList<Day> Days => new List<Day>
        {
            new Day01(),
            new Day02(),
            new Day03(),
            new Day04(),
            new Day05(),
            new Day06(),
            new Day07(),
            new Day08(),
            new Day09(),
            new Day10(),
            new Day11()
        };
    }
}