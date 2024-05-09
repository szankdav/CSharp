using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVirtualAndOverride
{
    internal class SajatList : List<object>
    {
        public List<string> naplo;

        public SajatList()
        {
            naplo = new List<string>();
        }

        public new void Add(object item)
        {
            base.Add(item);
            naplo.Add($"[{DateTime.Now}] [Uj elem hozzaadasa] - {item}");
        }
        
        public new void Remove(object item)
        {
            base.Remove(item);
            naplo.Add($"[{DateTime.Now}] [Elem torlese] - {item}");
        }

        public new void RemoveAt(int index)
        {
            naplo.Add($"[{DateTime.Now}] [Elem torlese index alapjan] - {base[index]}");
            base.RemoveAt(index);
        }
    }
}
