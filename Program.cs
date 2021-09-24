using System;
using System.Collections.Generic;
using System.Linq;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int foundTriangles = 0;

            List<PuzzleLine> lines = new()
            {
                new(1, 2, 7, 13, 21, 28),
                new(1, 3, 8, 14, 19, 23, 30),
                new(1, 4, 9, 12, 16, 20, 24, 31),
                new(1, 5, 6, 11, 17, 26, 27, 32),
                new(2, 3, 4, 5),
                new(7, 8, 9, 10, 11),
                new(13, 14, 15, 16, 17),
                new(21, 22, 23, 24, 25, 26),
                new(28, 29, 30, 31, 32),
                new(6, 10, 12, 15, 18, 19, 22, 29),
                new(18, 20, 25, 27)
            };

            foreach (var line1 in lines.ToList())
            {
                int idx = lines.IndexOf(line1);
                if (idx >= lines.Count - 1)
                    continue;

                foreach (var line2 in lines.Skip(idx + 1).ToList())
                {
                    int idx2 = lines.IndexOf(line2);
                    if (idx2 >= lines.Count - 1)
                        continue;

                    foreach (var line3 in lines.Skip(idx2 + 1).ToList())
                    {
                        var intersection12 = line1.PuzzlePoints.Intersect(line2.PuzzlePoints).ToList();
                        if (!intersection12.Any(i => !line3.PuzzlePoints.Contains(i)))
                            continue;

                        var intersection23 = line2.PuzzlePoints.Intersect(line3.PuzzlePoints).ToList();
                        if (!intersection23.Any(i => !line1.PuzzlePoints.Contains(i)))
                            continue;

                        var intersection31 = line3.PuzzlePoints.Intersect(line1.PuzzlePoints).ToList();
                        if (!intersection31.Any(i => !line2.PuzzlePoints.Contains(i)))
                            continue;
                        
                        foundTriangles++;
                        Console.WriteLine($"Found a triangle between points {intersection12.First()}, {intersection23.First()}, and {intersection31.First()}.");
                    }
                }
            }

            Console.WriteLine($"Found {foundTriangles} triangles.");

            Console.Write("Press any key to exit: ");
            Console.ReadKey();
        }
    }
}
