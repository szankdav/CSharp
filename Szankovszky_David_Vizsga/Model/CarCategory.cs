using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szankovszky_David_Vizsga
{
    public class CarCategory
    {
		#region PRIVATE FIELDS
		private int id;
		private string name;
        #endregion

        #region PUBLIC PROPERTIES
        public int Id { get => id; }
        public string Name { get => name; }
        #endregion

        #region CONSTRUCTORS
        public CarCategory(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        #endregion
    }
}
