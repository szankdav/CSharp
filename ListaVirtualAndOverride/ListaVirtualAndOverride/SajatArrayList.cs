using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVirtualAndOverride
{
    internal class SajatArrayList : ArrayList
    {
        public List<string> naplo;

        public SajatArrayList()
        {
            naplo = new List<string>();
        }

        public override int Add(object value)
        {
            naplo.Add($"[{DateTime.Now}] [Uj elem hozzaadasa] - {value}");
            return base.Add(value);
        }

        public override void Remove(object obj)
        {
            base.Remove(obj);
            naplo.Add($"[{DateTime.Now}] [Elem torlese] - {obj}");
        }

        public override void RemoveAt(int index)
        {
            naplo.Add($"[{DateTime.Now}] [Elem torlese index alapjan] - {base[index]}");
            base.RemoveAt(index);
        }
    }
}
