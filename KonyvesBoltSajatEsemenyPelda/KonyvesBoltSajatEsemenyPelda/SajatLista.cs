using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvesBoltSajatEsemenyPelda
{
    delegate void SajatImplementalasuEsemeny(Konyv konyv);
    internal class SajatLista : List<Konyv>
    {
        public event SajatImplementalasuEsemeny SajatEsemeny;
        public new void Remove(Konyv konyv)
        {
            base.Remove(konyv);
            SajatEsemeny?.Invoke(konyv);
        }
    }
}
