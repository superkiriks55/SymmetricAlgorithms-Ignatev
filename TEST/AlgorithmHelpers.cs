using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricAlgorithms_Ignatev.TEST
{
    public static class AlgorithmHelpers
    {
        /// <summary>
        /// Создает рандомную "соль" для шифрования файла
        /// </summary>
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (var rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    // Заполняет буфер сгенерированными данными
                    rng.GetBytes(data);
                }
            }

            return data;
        }


        public static void SetAlgKey(this SymmetricAlgorithm algorithm, string password, byte[] salt)
        {
            var key = new Rfc2898DeriveBytes(password, salt, 50000);
            algorithm.Key = key.GetBytes(algorithm.KeySize / 8);
            algorithm.IV = key.GetBytes(algorithm.BlockSize / 8);
        }

        public static void SetAlgProps(this SymmetricAlgorithm algorithm, int keySize, int blockSize)
        {
            algorithm.KeySize = keySize;
            algorithm.BlockSize = blockSize;
            algorithm.Padding = PaddingMode.PKCS7;
        }

        #region Режимы работы алгоритмов

        /// <summary>
        /// Возвращает допустимые режимы работы списком
        /// </summary>
        public static List<CipherMode> SupportedModes
        {
            get
            {
                return new List<CipherMode> { CipherMode.CBC, CipherMode.ECB };
            }
        }

        /// <summary>
        /// Возвращает наименование режима работы
        /// </summary>
        public static Func<CipherMode, string> GetStringMode = (CipherMode mode)
            => Enum.GetName(typeof(CipherMode), mode);

        #endregion
    }
}