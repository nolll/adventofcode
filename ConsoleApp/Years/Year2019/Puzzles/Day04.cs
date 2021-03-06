﻿using System;
using System.Linq;

namespace ConsoleApp.Years.Year2019.Puzzles
{
    public class Day04 : Day2019
    {
        public Day04() : base(4)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var passwordBounds = Input.Split('-');
            var passwordLowerbound = int.Parse(passwordBounds[0]);
            var passwordUpperbound = int.Parse(passwordBounds[1]);

            var passwordFinder = new Core.Passwords.PasswordFinder();
            var passwords = passwordFinder.FindPart1(passwordLowerbound, passwordUpperbound);
            var passwordCount = passwords.Count();
            return new PuzzleResult(passwordCount, 530);
        }

        public override PuzzleResult RunPart2()
        {
            var passwordBounds = Input.Split('-');
            var passwordLowerbound = int.Parse(passwordBounds[0]);
            var passwordUpperbound = int.Parse(passwordBounds[1]);

            var passwordFinder = new Core.Passwords.PasswordFinder();
            var passwords = passwordFinder.FindPart2(passwordLowerbound, passwordUpperbound);
            var passwordCount = passwords.Count();
            return new PuzzleResult(passwordCount, 324);
        }

        private const string Input = "357253-892942";
    }
}