﻿using System;
using Core.CardShuffling;

namespace ConsoleApp.Years.Year2019
{
    public class Day22 : Day
    {
        public Day22() : base(22)
        {
        }

        protected override void RunDay()
        {
            WritePartTitle();
            var shuffler = new CardShuffler(10007);
            shuffler.Shuffle(Input);

            var position = shuffler.Deck.IndexOf(2019);

            Console.WriteLine($"Position of card 2019: {position}");
        }

        private const string Input = @"cut 1470
deal with increment 46
cut -6481
deal with increment 70
cut 547
deal with increment 48
cut -6479
deal with increment 69
cut -5203
deal with increment 13
deal into new stack
deal with increment 73
deal into new stack
cut -6689
deal with increment 61
cut -9853
deal with increment 48
cut -9673
deal into new stack
deal with increment 3
deal into new stack
deal with increment 64
cut 5789
deal with increment 66
deal into new stack
deal with increment 70
cut -2588
deal with increment 6
deal into new stack
deal with increment 6
cut -7829
deal with increment 49
deal into new stack
deal with increment 19
cut 9777
deal into new stack
deal with increment 27
cut 6210
deal into new stack
deal with increment 12
cut 6309
deal with increment 12
cut -9458
deal with increment 5
cut 6369
deal with increment 27
cut 2278
deal with increment 42
cut 6656
deal with increment 62
cut -1424
deal with increment 25
deal into new stack
deal with increment 12
deal into new stack
cut -7399
deal into new stack
cut -8925
deal with increment 47
deal into new stack
cut 5249
deal with increment 65
cut -213
deal into new stack
cut 6426
deal with increment 22
cut -6683
deal with increment 38
deal into new stack
deal with increment 62
cut 6855
deal with increment 75
cut 4965
deal into new stack
cut -5792
deal with increment 30
cut 9250
deal with increment 19
cut -948
deal with increment 26
cut -5123
deal with increment 68
cut -604
deal with increment 41
deal into new stack
deal with increment 45
cut 5572
deal into new stack
cut 3853
deal with increment 21
cut 1036
deal into new stack
deal with increment 6
cut 8114
deal into new stack
deal with increment 38
cut -5
deal with increment 58
cut 9539
deal with increment 19";
    }
}