using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Triangle
{
    public class PuzzleLine
    {
        public PuzzleLine(params int[] points)
        {
            PuzzlePoints.AddRange(points);
        }

        public List<int> PuzzlePoints { get;set; } = new();
    }
}