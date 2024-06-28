using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__13._1
{
    internal class GroupEnumerator(List<Student> group) : IEnumerator
    {
        public List<Student> group = new List<Student>();

        int position = -1;

        public void GroupEnum(List<Student> group)
        {
            this.group = group;
        }
        public bool MoveNext()
        {
            position++;
            return (position < group.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return group[position];
            }
        }
    }
}
