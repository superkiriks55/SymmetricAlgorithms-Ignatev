using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricAlgorithms_Ignatev.TEST
{
    public class AlgorithmResultModel
    {
        /// <summary>
        /// Наименование алгоритма
        /// </summary
        [DisplayName("Наименование")]
        public string AlgorithmName { get; set; }

        /// <summary>
        /// Режим работы алгоритма
        /// </summary>
        [DisplayName("Режим работы")]
        public string AlgorithmMode { get; set; }

        /// <summary>
        /// Время, затраченное на шифрацию, с
        /// </summary>
        [DisplayName("Время, затраченное на шифрацию, с")]
        public double EncryptionTime { get; set; }

        /// <summary>
        /// Время, затраченное на дешифрацию, с
        /// </summary>
        [DisplayName("Время, затраченное на дешифрацию, с")]
        public double DecryptionTime { get; set; }

        /// <summary>
        /// Общее время, затраченное на обработку файла, c
        /// </summary>
        [DisplayName("Общее время, затраченное на обработку файла, c")]
        public double GeneralTime
        {
            get { return Math.Round(EncryptionTime + DecryptionTime, 3); }
        }
    }
}
