﻿using System;
using System.Linq;
using Core.PasswordPolicy;
using Core.Tools;

namespace ConsoleApp.Years.Year2020.Puzzles
{
    public class Day02 : Day2020
    {
        public Day02() : base(2)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var validator = new PasswordPolicyValidator();
            var policies = PuzzleInputReader.ReadLines(FileInput);
            var count = policies.Count(validator.IsValidAccordingToRuleOne);
            return new PuzzleResult(count, 556);
        }

        public override PuzzleResult RunPart2()
        {
            var validator = new PasswordPolicyValidator();
            var policies = PuzzleInputReader.ReadLines(FileInput);
            var count = policies.Count(validator.IsValidAccordingToRuleTwo);
            return new PuzzleResult(count, 605);
        }
    }
}