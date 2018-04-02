using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Helpers
{
    public static class EnumerableExtentions
    {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<T> items, 
            Func<T, IEnumerable<T>> before, Func<T, IEnumerable<T>> after)
        {
            foreach (var item in items)
            {
                if (before != null)
                {
                    foreach (var b in before(item))
                    {
                        yield return b;
                    }
                }
                yield return item;
                if (after != null)
                {
                    foreach (var a in after(item))
                    {
                        yield return a;
                    }
                }
            }
        }
    }
}
