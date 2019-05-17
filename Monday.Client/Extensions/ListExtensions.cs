using System.Collections.Generic;
using System.Linq;

namespace Monday.Client.Extensions
{
    public static class ListExtensions
    {
        public static List<List<T>> ChunkBy<T>(this List<T> source, int pageSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / pageSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }
    }
}