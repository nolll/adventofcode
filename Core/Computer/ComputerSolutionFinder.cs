﻿namespace Core.Computer
{
    public class ComputerSolutionFinder
    {
        private const int LowerBound = 1;
        private const int UpperBound = 99;

        public Result FindSolution(int target)
        {
            var computer = new IntCodeComputer();
            for (var noun = LowerBound; noun <= UpperBound; noun++)
            {
                for (var verb = LowerBound; verb <= UpperBound; verb++)
                {
                    var result = computer.Run(noun, verb);
                    if(result.Integer == target)
                        return new Result(noun, verb, target);
                }
            }

            return null;
        }

        public class Result
        {
            public int Noun { get; }
            public int Verb { get; }
            public int Integer { get; }

            public Result(int noun, int verb, int integer)
            {
                Noun = noun;
                Verb = verb;
                Integer = integer;
            }
        }
    }
}