using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricAlgorithms_Ignatev.TEST
{
    public class FormData
    {
        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; private set; }

        public FormData(string filePath, string password)
        {
            FilePath = filePath;
            Password = password;
        }
    }
}
