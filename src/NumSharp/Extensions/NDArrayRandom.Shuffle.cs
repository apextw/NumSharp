﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace NumSharp.Extensions
{
    public static partial class NDArrayRandomExtensions
    {
        public static void Shuffle(this NDArrayRandom rand, NDArray<double> list)
        {
            var rng = new Random();
            var count = list.Shape.Shapes[0];
            while (count > 1)
            {
                count--;
                var k = rng.Next(count + 1);
                var value = list[k];
                list[k] = list[count];
                list[count] = value;
            }
        }
    }
}
