using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVirtualAndOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SajatList sajatLista = new SajatList(); // ???????????? O valojaban egy lista IS?
            SajatArrayList sajatArrayLista = new SajatArrayList();
            // sajatLista feltoltese
            sajatLista.Add(5);
            sajatLista.Add("Szia");
            sajatLista.Add(true);
            // sajatArrayLista feltoltese
            sajatArrayLista.Add(5);
            sajatArrayLista.Add("Szia");
            sajatArrayLista.Add(true);
            // Naplo kiirasa
            Console.WriteLine("A sajatLista naplo tartalma:");
            NaploKiiras(sajatLista.naplo);
            Console.WriteLine("A sajatArrayLista naplo tartalma:");
            NaploKiiras(sajatArrayLista.naplo);

            List<object> osLista = sajatLista; //???????? Leszarmazott?
            ArrayList osArrayLista = sajatArrayLista; //?????????? Polimorfizmus miatt? Vagy mert latja, hogy a sajatArrayList egy leszarmazott osztaly. (Mivel abbol jott letre, ezert valojaban az os is sajatArrayLista tipusu lesz)
            osLista.Add(3.14);
            osArrayLista.Add(3.14);
            // Naplo kiirasa
            Console.WriteLine("A sajatLista naplo tartalma az os tipus hasznalata utan:");
            Console.WriteLine($"{osLista[3]}");
            NaploKiiras(sajatLista.naplo);
            Console.WriteLine("A sajatArrayLista naplo tartalma az os tipus hasznalata utan:");
            NaploKiiras(sajatArrayLista.naplo);
            Console.ReadKey();
        }

        static void NaploKiiras(List<string> naplo)
        {
            foreach (string item in naplo)
            {
                Console.WriteLine($"\t- {item}");
            }
        }
    }
}
