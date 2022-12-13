﻿var output = File.ReadAllText("input.txt")
                .Split($"{Environment.NewLine}{Environment.NewLine}")
                .Select(s => s
                    .Split(Environment.NewLine)
                    .Select(x => int.Parse(x))
                    .Sum())
                .OrderDescending()
                .Take(3);

Console.WriteLine(string.Join(Environment.NewLine, output));