﻿namespace MoodyEye.ConsoleMonitor;

using Spectre.Console;

public class Display
{
    public async Task RunAsync()
    {
        AnsiConsole.Write(new BarChart()
            .Width(60)
            .Label("[green bold underline]Number of fruits[/]")
            .CenterLabel()
            .AddItem("Apple", 12, Color.Yellow)
            .AddItem("Orange", 54, Color.Green)
            .AddItem("Banana", 33, Color.Red));
    }
}