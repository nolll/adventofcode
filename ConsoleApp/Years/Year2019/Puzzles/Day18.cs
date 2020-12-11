﻿using System;
using Core.UndergroundVault;

namespace ConsoleApp.Years.Year2019.Puzzles
{
    public class Day18 : Day2019
    {
        public Day18() : base(18)
        {
        }

        protected override void RunDay()
        {
            WritePartTitle();
            var keyCollector1 = new KeyCollector(FileInput);
            keyCollector1.Run();

            Console.WriteLine($"Number of steps to collect all keys with one robot: {keyCollector1.ShortestPath}");

            WritePartTitle();
            var keyCollector2 = new KeyCollector(GeneratedMapFromStep1);
            keyCollector2.Run();

            Console.WriteLine($"Number of steps to collect all keys with four robots: {keyCollector2.ShortestPath}");
        }

        private const string GeneratedMapFromStep1 = @"
#################################################################################
#...#z..#.....#...#...#.........#...#...#.............................#...#.....#
#.#.#.#.#.#.#.#.#.#.#.#####.###.###.#.#.#####.#######################H#.#.###.#.#
#.#.#.#...#.#...#...#.....#.#.#...#f..#.#...#.#.......#...#.........#...#.....#.#
#.#.#.#####.#############.#.#.###.###.#.#.#.#.#.#####.#.#.###.#####.###########.#
#.#...#...#.#.........#.....#...#...#.#.#.#...#.....#...#...#.#...#...#...#.....#
#.#####.#.#.#.#######.#######.#####.#.#.#.###.#####.#######I#.#.#.#####X#.#.#####
#.#...#.#.#...#.....#...#...#.....#.#.#.#...#...#.#.#.....#.#.#.#.......#.#.#...#
#.#.#.###.#######.#.###.###.#.#.###.#.#.#.#.###.#.#.#.###.#.#.#.#########.#.#.#.#
#.#.#...#.#.......#...#.#...#.#...#.#.#.#.#.#...#w#b..#.#.#.#.....#...#...#.#.#.#
#.#.###.#.#.#.#######.#.#.###.###.#.###.###.#.###.#####.#.#.###.###Y#.#.#.#.#.###
#.#.#...#...#...#.....#.#.#...#.#...#...#...#.......#.....#...#.#...#.#.#.#.#...#
#.#.#.#########.#.#####.#.#.###.#####.#.#.###########.#####.#.#.#.###.#.###.###.#
#.#.#...#.......#.#.....#.....#.......#.#............j#...#.#.#.#...#.#.....#s..#
#.#.###.#.###.#####.#.#######.#####.###.###############.#.###.###.###.#.#####.#G#
#.C.#.#...#...#.....#.#.....#.....#...#.#.............#.#.....#...#...#.#.....#.#
#####.#####.###.#######.###.#####.###.#.#.###.#####.###.#.#####.###.###.#.#####.#
#...#...#...#...#.....#.#.#.#.......#.#.#.#.#.#.....#...#.#.....#.#...#...#...#.#
#.#.###.#.###.#.#.###.#.#.#.#######.#.#.#.#.#.#.#####.#####.#####.###.#######.#.#
#.#...#...#.#.#.#...#...#.#.#.....#...#.#.#.#.#.#.....#...........T.#.#...U.#.#.#
#.###.#.###.#.#.#.#####.#.#.#.###.#####.#.#.#.###.#.###.#############.#.###.#.#.#
#...#.#.....#.#.#.#...#...#.....#.....#.#...#.#...#.#...#.P...#.E...#...#...#...#
#.#.#.#####.#.###.#.###############.#.###.###.#.###.#.###.#####.###.#####.###.###
#.#.#.....#.#.#...#...............#.#...#.#...#...#.#.#.#...#...#.#.#.N.#...#...#
#.#.#####.###.#.#################.#.###.###.#.###R#.#.#.###.###.#.#.#.#.###.###.#
#.#.....#.#...#...#.........#...#.#...#.#...#.#...#.#.#...#p#...#.#e#.#.....#...#
#.#####.#.#.#####.###.#.#####.#.#.#####.#.#####.###.#V###.#.#.###.#.#.#######.###
#.#...#.#...#...#...#.#.#.....#.#.....#.#.....#.#...#...#.#...#...#...#...#...#.#
#.#.#.#.###.#.#.###.#.#.#.#####.#####.#.#.###.#.#######.#.#######.#######.#.###.#
#.#.#.#...#.#.#.....#.#.......#...#...#.#.#...#.........#...#.........#...#.....#
#.#.#.###.###.#######.#########.#.#.###.###.#.###########.#.#.#.#####.#.#.#####.#
#m#.#...#.....#...#.....#...#...#.#.....#...#...#...#.....#.#.#.#.......#...#...#
#.###O#.#######.#.#####.#.#.#.###.#######.#####.#.###.#.###.#.#.###########.#.###
#...#.#.#.......#.....#.#.#.#...#.....#.#.#...#...#..k#...#.#.#.#.....#...#.#.#.#
###.#.#.###.#########.###.#.###.#####.#.#.#.#.###.#.#####.###L#.#.###.#.#.###.#.#
#.#.#.#.....#l#.....#a..#.#.....#...#.#.#.#.#.#...#...#.#.#...#.#.#.#...#...#.#.#
#.#.#.#######.#.###.###.#.#######.###.#.#.#.#.#######.#.#.#.###.#.#.#######.#.#.#
#...#.#.#.K...#...#...#...#...........#.#...#.......#.#.#.#.#...#...#o....#.#...#
#Q###.#.#.#.#####.#.#######.###########.#.#######.###.#.#.#.#.#####.#.###.#.###.#
#.....#...#.......#............d.......@#@......#.......#...#.........#...#.....#
#################################################################################
#...........#.....#.....#...#.....#....@#@#.....#...D.......#...#.........#.....#
#.#.#######.#.###.#.###.#.#.###.#.###.#.#.#.#.###.###.#.#####.#.#.###.###.#.###.#
#g#.....#...#.#.#.#.#.....#.....#.#...#.#...#.....#.#.#.#.....#.....#.#.....#...#
#.#####.#.###.#.#.#.#############.#.###.#.#########.#.###.#########.#.#########.#
#.....#.#.#...#.....#...#...#...#.#...#.#.......#...#.....#...#...#.#.#.......#.#
#######.#.###.#######.#.#.#.#.#.#.#.#.#########.#.#########.#.#.#.###.#.#####.#.#
#.......#.....#.......#...#.#.#...#.#...#.....#.#.#.........#...#.....#...#.#.#.#
#.###########.#.###########.#.#########.#.#.###.#.#.#####################.#.#M#.#
#.#.........#.#.#.....#.....#...#.......#.#.#...#.#.....#.......#...........#.#.#
#.#.#######.#.#.#####.#.#######.###.###.#.#.#.###.#####.#.#####.#.###########.#.#
#.#.......#.#.#.....#.#.#.#...#...#.#.#.#.#.#.........#...#.#...#.....#.....#.#.#
#.#######.#.#######.#.#.#.#.#.###.#.#.#.#.#.#########.#####.#.###.#####.###.#.#.#
#.#.....S.#.......#.#.#.#.#.#.....#.#...#.#.........#...#...#.....#...#.#...#.#.#
#.#.#########.#.###.#.#.#.#.#######.#.###########.#.###.###.#######.#.#.#.###.#.#
#...#.......#.#.#.....#.#.#...#.....#...#.......#.#.......#...#.....#...#...#.#.#
#######.###.#.###.#####.#.###.#.#######.#.#####.#.#######.###.#.###########.#.#.#
#.....#.#...#.....#.....#...#...#...#...#.#.#...#.#.....#.....#.#.....#.....#.#.#
#.###.#.#.#########.#####.#########.#.###.#.#.#####.###.#.#####.#.###.#.#####.#A#
#.#.....#.....#...#...#...#.........#...#...#.....#.#...#.#...#.#...#.#.#.....#.#
#.#.###########.#.###.#.#.#.###.#.#####.###F#####.#.#.#####.#.#.###.#.#.###.###.#
#.#...#.........#...#.#.#...#...#.#.....#.#...#.#v..#....t#.#n#...#.#.#.#...#...#
#.#.###.###########.###.#####.#####.#####.###.#.#########.#.###.#.#.###.#.###.###
#.#.#.....#.........#.#.#...#...#...#...#...#.#.......#...#...#.#.#.#.....#.#.#.#
#.#.#.#####.#######.#.#.#.#####.#.#####.#.###.###.###.#.#.###.###.#.#.#####.#.#.#
#.#.#...#...#.....#...#.#.#...#.#.#...#.#...#.....#...#.#...#...#.#...#...#...#.#
#.#####.#.#.#.###.###.#.#.#.#.#.#.#.#.#.###.#####.#####.#######.#.###.#.#.###.#.#
#.#.B.#.#.#.#...#...#.#.#...#.#.#...#.#.#.....#...#..y#.#..u....#...#.#.#...#.#.#
#.#.#.#.#.#.###.###.###.#####.#.#####.#.#.###.#.###.#.#.#.#######.#.###.###.#.#.#
#.#.#.#.#.#.#.....#...#.......#.....#...#.#.#.#.#.#.#...#.#.......#.......#.#...#
#.#.#.#.#.###.#######.#######.#####.###.#.#.#.#.#.#.#####.#.#############.#.###.#
#...#...#.....#.....#.......#.#.#...#.#.#.#...#...#.......#.#.........#...#c#.#.#
#.#############.###.#######.#.#.#.#.#.#.#.#.#####.#########.#.#######.#.###.#.#.#
#.#...........#...#...#...#.#.#.#.#...#.#.#.#...#.#.#.....Z.#.......#.#.#...#...#
#.#########.#####.###.#.#.#.#.#.#.#.###.#.#.#.#.#.#.#.#############.#.###.###.###
#i#.......#.#...#x#..h..#...#.#.#.#.#...#.#...#r#.#...#.....#.J.....#...#...#...#
#.#.#####.#.#.#.#.#########.#.#.#.###.###.###.###.#####.###.#.#########.###.###.#
#.#...#...#.#.#...#...#...#.#.#.#.#...#.#...#.#...#...#.#.#...#.......#...#.#q..#
#.###.#.###.#.#####.#.#.#.###.#.#.#.###.#.#.###.###.#.#.#.#####.###.#####.#.#.###
#.....#.....#.......#...#.......#.......#.#.........#...#...W.....#.........#...#
#################################################################################";

    }
}