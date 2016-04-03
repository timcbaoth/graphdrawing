using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDrawing.Collections
{
    public interface IReadOnlySet<T> : IReadOnlyCollection<T>
    {
        bool Contains(T element);
    }
}
