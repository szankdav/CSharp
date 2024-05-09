using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegatePelda
{
    delegate void MentesMetodusok(string utvonal);
    internal class Vizsga
    {
        #region PRIVATE FIELDS
        string cim;
        string feladat;
        string kepUtvonal;
        #endregion

        #region PUBLIC PROPERTIES
        public string Cim { get => cim; private set => cim = value; }
        public string Feladat { get => feladat; private set => feladat = value; }
        public string KepUtvonal { get => kepUtvonal; private set => kepUtvonal = value; }
        #endregion

        #region CONSTRUCTORS
        public Vizsga(string cim, string feladat, string kepUtvonal = "")
        {
            Cim = cim;
            Feladat = feladat;
            KepUtvonal = kepUtvonal;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"Vizsdga cime: {Cim}";
        }

        public void VizsgaMentes(string utvonal)
        {
            if (Directory.Exists(utvonal) && utvonal.Last() == '\\')
            {
                StreamWriter writer = new StreamWriter($"{utvonal}{Cim}.html");
                writer.WriteLine(String.Format("<h1>{0}</h1>", Cim));
                writer.WriteLine(String.Format("<p>{0}</p>", Feladat));
                if (kepUtvonal != "")
                {
                    writer.WriteLine("<img src=\"{0}\"/>", kepUtvonal.Split('\\').Last());
                }
                writer.Close();
            }
            else
            {
                throw new ArgumentException("A megadott utvonal hibas!");
            }
        }

        public void KepMentes(string utvonal)
        {
            if (Directory.Exists(utvonal) && utvonal.Last() == '\\')
            {
                try
                {
                    File.Copy(kepUtvonal, $"{utvonal}{kepUtvonal.Split('\\').Last()}", true);
                }
                catch
                {
                    throw new IOException("A kep masolasa sikertelen");
                }
            }
            else
            {
                throw new ArgumentException("A megadott utvonal hibas!");
            }
        }
        #endregion
    }
}
