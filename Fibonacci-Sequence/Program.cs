// See https://aka.ms/new-console-template for more information
using Fibonacci_Sequence;

var series = Fibonacci(10);
Console.WriteLine(string.Join(",", series));

IReadOnlyList<int> Fibonacci(int num)
{
    var series = new List<int> { 0, 1 };

    (2..num)
        .AsSequence()
        .Select(it => series[it - 1] + series[it - 2])
        .ForEach(it => series.Add(it));

    return series.AsReadOnly();
}


