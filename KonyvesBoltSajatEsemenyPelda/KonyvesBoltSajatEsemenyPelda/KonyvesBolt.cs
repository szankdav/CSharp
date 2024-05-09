using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvesBoltSajatEsemenyPelda
{
    delegate void KonyvErkezettEsemenyKezelo(Konyv ujKonyv);

    internal class KonyvesBolt : List<Konyv> // --> Korlatoztam, hogy a hogy a KonyvesBolt osztaly csak egy Lista tipusu elemet hordazhat magaban, ami kizarolag Konyv tipusu elemeket tartalmazhat 
    {
        public event KonyvErkezettEsemenyKezelo KonyvErkezett;

        public new void Add(Konyv ujKonyv)
        {
            base.Add(ujKonyv);
            KonyvErkezett?.Invoke(ujKonyv);
        }
    }
}
