﻿using System;
using Core.DominoBridge;

namespace ConsoleApp.Years.Year2017
{
    public class Day24 : Day
    {
        public Day24() : base(24)
        {
        }

        protected override void RunDay()
        {
            WritePartTitle();
            var builder1 = new BridgeBuilder(Input, false);
            var bridge1 = builder1.Build();
            Console.WriteLine($"Strength of strongest bridge {bridge1.Strength}.");

            WritePartTitle();
            var builder2 = new BridgeBuilder(Input, true);
            var bridge2 = builder2.Build();
            Console.WriteLine($"Strength of longest bridge {bridge2.Strength}.");
        }

        private const string Input = @"
42/37
28/28
29/25
45/8
35/23
49/20
44/4
15/33
14/19
31/44
39/14
25/17
34/34
38/42
8/42
15/28
0/7
49/12
18/36
45/45
28/7
30/43
23/41
0/35
18/9
3/31
20/31
10/40
0/22
1/23
20/47
38/36
15/8
34/32
30/30
30/44
19/28
46/15
34/50
40/20
27/39
3/14
43/45
50/42
1/33
6/39
46/44
22/35
15/20
43/31
23/23
19/27
47/15
43/43
25/36
26/38
1/10";
    }
}