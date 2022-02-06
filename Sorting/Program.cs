// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Sorting;
using Sorting.Methods;

void Run(ISort method)
{
    int[] data = new int[10] { 10, 8, 9, 4, 6, 5, 7, 2, 3, 1 };
    Stopwatch stop = new Stopwatch();

    Console.WriteLine(method.GetType().ToString());
    stop.Start();
    var sorted = method.Sort(data);
    stop.Stop();
    for (int i = 0; i < sorted.Length; i++)
    {
        Console.Write(sorted[i] + " ");
    }
    Console.WriteLine("- Time Elapsed: " + stop.Elapsed);
}

Run(new BubbleSort());
Run(new InsertionSort());