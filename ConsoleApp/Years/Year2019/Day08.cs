﻿using System;
using Core.SpaceImages;
using Data.Inputs;

namespace ConsoleApp.Years.Year2019
{
    public class Day08 : Day
    {
        public Day08() : base(8)
        {
        }

        protected override void RunDay()
        {
            WritePartTitle();
            var image = new SpaceImage(InputData.ImageData);
            var checksum = image.Checksum;
            Console.WriteLine($"Checksum: {checksum}");

            WritePartTitle();
            Console.WriteLine(image.Print());
        }
    }
}