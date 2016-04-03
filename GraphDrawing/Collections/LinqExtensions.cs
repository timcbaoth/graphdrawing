using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDrawing.Collections
{
    public static class LinqExtensions
    {
        public static IReadOnlySet<T> ToReadOnlySet<T>(IEnumerable<T> source, IEqualityComparer<T> equalityComparer = null)
        {
            return new ReadOnlySet<T>(source, equalityComparer);
        }
    }
}
