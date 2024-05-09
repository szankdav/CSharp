using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JárműJavítóMűhelyKezelő.Classes
{
    internal class ABKivetelKezelo : Exception
    {
        #region PRIVATE FIELDS
        string eredetiHibaUzenet;
        #endregion

        #region PUBLIC PROPERTIES
        public string EredetiHibaUzenet { get => eredetiHibaUzenet; }
        #endregion

        #region CONSTRUCTORS
        public ABKivetelKezelo(string hibaUzenet, string eredetiHibaUzenet) : base(hibaUzenet)
        {
            this.eredetiHibaUzenet = eredetiHibaUzenet;
        }
        #endregion

        #region METHODS
        #endregion

    }
}
