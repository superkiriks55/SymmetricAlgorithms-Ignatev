using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricAlgorithms_Ignatev.TEST
{
    public class Exception_USER
    {
        /// <summary>
        /// Сообщение, возникающее при отсутствии текста в поле пароля
        /// </summary>
        public const string PASSWORD_ERROR = "Введите пароль!";

        /// <summary>
        /// Сообщение, возникающее, если на форме обнаружены незаполненные поля
        /// </summary>
        public const string EMPTY_FIELDS_ERROR = "Заполните необходимые для операции поля!";

        /// <summary>
        /// Сообщение, возникающее, если файл или путь не найден
        /// </summary>
        public const string FILE_NOT_FOUND_ERROR =
            "Файл не найден или путь к нему некорректен";
    }
}
