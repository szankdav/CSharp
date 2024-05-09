using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_test
{
    public class Car
    {
        #region PRIVATE FIELDS
        int id;
        string plateNumber;
        string model;
        DateTime technicalValidty;
        DateTime insuranceValidity;
        #endregion

        #region PUBLIC PROPERTIES
        public int Id { get => id; set => id = value; }
        public string PlateNumber { get => plateNumber; set => plateNumber = value; }
        public string Model { get => model; set => model = value; }
        public DateTime TechnicalValidty { get => technicalValidty; set => technicalValidty = value; }
        public DateTime InsuranceValidity { get => insuranceValidity; set => insuranceValidity = value; }
        #endregion

        #region CONSTRUCTORS
        public Car(int id, string plateNumber, string model, DateTime technicalValidty, DateTime insuranceValidity)
        {
            Id = id;
            PlateNumber = plateNumber;
            Model = model;
            TechnicalValidty = technicalValidty;
            InsuranceValidity = insuranceValidity;
        }
        #endregion
    }
}
