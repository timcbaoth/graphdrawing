using System.Collections;
using System.Collections.Generic;

namespace GraphDrawing.Collections
{
    public class ReadOnlySet<T> : IReadOnlySet<T>
    {
        private readonly ISet<T> underlyingSet;
        
        public ReadOnlySet(IEnumerable<T> source, IEqualityComparer<T> equalityComparer)
        {
            var set = source as ISet<T>;
            underlyingSet = set ?? (equalityComparer != null
                ? new HashSet<T>(source, equalityComparer)
                : new HashSet<T>(source));
        }

        public IEnumerator<T> GetEnumerator()
        {
            return underlyingSet.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return underlyingSet.GetEnumerator();
        }

        public bool Contains(T element)
        {
            return underlyingSet.Contains(element);
        }

        public int Count => underlyingSet.Count;
    }
}
