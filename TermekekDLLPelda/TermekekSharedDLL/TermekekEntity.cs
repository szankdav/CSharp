using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermekekSharedDLL
{
    public static class TermekekEntity
    {
        // Termekek CSV beolvasasa
        public static List<Termek> TermekFromCSV(string path, char szeparator)
        {
            if (File.Exists(path))
            {
                List<Termek> beolvasas = new List<Termek>();
                using (StreamReader reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        try
                        {
                            beolvasas.Add(new Termek(reader.ReadLine(), szeparator));
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    reader.Close();
                    return beolvasas;
                }
            }
            else
            {
                throw new FileNotFoundException($"A megadott fajl nem letezik: {path}!");
            }
            
        }

        // Termekek CSV mentese
        public static void TermekekToCSV(string path, List<Termek> termekek, char szeparator)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Termek termek in termekek)
                {
                    try
                    {
                        writer.WriteLine(termek.ToCSV(szeparator));
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                writer.Close();
            }
        }
    }
}
