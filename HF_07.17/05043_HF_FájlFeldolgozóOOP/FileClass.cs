using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05043_HF_FájlFeldolgozóOOP
{
    internal class FileClass
    {
        #region PRIVATE FIELDS
        private string fileNev;
        private DateTime modositasDatuma;
        private long fileMeret;
        #endregion

        #region PROPERTIES 
        public string FileNev { get => fileNev; set => fileNev = value; }
        public DateTime ModositasDatuma { get => modositasDatuma; set => modositasDatuma = value; }
        public long FileMeret { get => fileMeret; set => fileMeret = value; }
        #endregion

        #region CONSTRUCTORS
        public FileClass(string fileName, DateTime modifiedDate, long fileSize)
        {
            fileNev = fileName;
            modositasDatuma = modifiedDate;
            fileMeret = fileSize;
        }
        #endregion

        #region METHODS
        #endregion
    }
}
