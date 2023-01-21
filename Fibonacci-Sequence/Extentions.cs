using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    public static class CustomExtentions
    {
        public static IEnumerable<int> AsSequence(this Range range)
        {
            for (var i = range.Start.Value; i <= range.End.Value; i++)
                yield return i;
        }

        public static void ForEach<T>(this IEnumerable<T> seq, Action<T> action)
        {
            foreach (var item in seq) action(item);
        }
    }
}
