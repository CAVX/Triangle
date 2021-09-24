# #Survivor41 Triangle Puzzle Solver

After watching the premiere of Survivor season 41, I wrote [a tweet](https://twitter.com/CAVX/status/1441135333412724741) about making a script to verify the amount of triangles in the puzzle.

This simple script was built to be created quickly and wasn't coded with perfect optimization in mind. It's a .NET 5 console application written in C#.

In order to define the lines, I mapped out each point (defined as a location where two or more lines intersect) to a sequential number, and then created a list of lines using those numbers to indicate which points a given line crossed. I then iterated through all combinations of three lines to ensure that each line has a point in common with each other line, and that it's not intersecting with a different line.

See my line mappings and the output below (also included in the tweet)

Point Mapping | Script Output
------------ | -------------
![Screenshot of Triangle Puzzle](https://pbs.twimg.com/media/E__w8iyVkAAxV11?format=jpg&name=small) | ![Code output for this triangle](https://pbs.twimg.com/media/E__w8tFVQAIABbW?format=png&name=medium)


Just run and build to use the code! There's no configuration, but you can pretty easily edit the list of lines to test other similar puzzles.
