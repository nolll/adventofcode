﻿using System;
using Core.AirDuct;
using Core.ClockSignal;

namespace ConsoleApp.Years.Year2016
{
    public class Day25 : Day
    {
        public Day25() : base(25)
        {
        }

        protected override void RunDay()
        {
            WritePartTitle();
            var generator = new ClockSignalGenerator();
            Console.WriteLine($"Lowest A: {generator.LowestA}");
        }

        private const string Input = @"
cpy a d
cpy 4 c
cpy 633 b
inc d
dec b
jnz b -2
dec c
jnz c -5
cpy d a
jnz 0 0
cpy a b
cpy 0 a
cpy 2 c
jnz b 2
jnz 1 6
dec b
dec c
jnz c -4
inc a
jnz 1 -7
cpy 2 b
jnz c 2
jnz 1 4
dec b
dec c
jnz 1 -4
jnz 0 0
out b
jnz a -19
jnz 1 -21";
    }
}