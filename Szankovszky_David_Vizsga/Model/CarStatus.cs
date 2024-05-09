using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szankovszky_David_Vizsga.Model
{
    public class CarStatus
    {
        #region PRIVATE FIELDS
        private int id;
        private string name;
        private int value;
        #endregion

        #region PUBLIC PROPERTIES
        public int Id { get => id; }
        public string Name { get => name; }
        public int Value { get => value; }
        #endregion

        #region CONSTRUCTORS
        public CarStatus(int id, string name, int value)
        {
            this.id = id;
            this.name = name;
            this.value = value;
        }
        #endregion
    }
}
