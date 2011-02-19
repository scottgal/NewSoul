using System.Collections.Generic;

namespace Entities
{
    public class Component : BaseEntity
    {
        private SortedList<int, Argument> _arguments = new SortedList<int, Argument>(Comparer<int>.Default);
        public SortedList<int, Argument> Arguments { get { return _arguments; } set { _arguments = value; } }
    }
}
