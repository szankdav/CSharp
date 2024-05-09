using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorKeszletManager
{
    
    internal class SajatLista : List<Butor>
    {
        public delegate void HozzaadasEsemeny(Butor butor);
        public event HozzaadasEsemeny Hozzaadas;

        public delegate void TorlesEsemeny(Butor butor);
        public event TorlesEsemeny Torles;
        public new void Add(Butor butor)
        {
            base.Add(butor);
            Hozzaadas?.Invoke(butor);
        }

        public new void Remove(Butor butor)
        {
            base.Remove(butor);
            Torles?.Invoke(butor);
        }
    }
}
