using SymmetricAlgorithms_Ignatev.TEST;
using System.Security.Cryptography;

namespace SymmetricAlgorithms_Ignatev // твой неймспейс
{
    public static class AlgFactory
    {
        // ks = 256. bs = 128
        public static SymmetricAlgorithm GetAES(
            FormData parameters,
            byte[] salt,
            CipherMode mode)
        {
            var aes = new RijndaelManaged();
            aes.Mode = mode;
            var key = new Rfc2898DeriveBytes(parameters.Password,
                salt, 50000);
            aes.SetAlgProps(key, 256, 128);
            return aes;
        }

        // ks = 64. bs = 64
        public static SymmetricAlgorithm GetDES(
            FormData parameters,
            byte[] salt,
            CipherMode mode)
        {
            DES des = DES.Create();
            des.Mode = mode;
            var key = new Rfc2898DeriveBytes(parameters.Password,
                salt, 50000);
            des.SetAlgProps(key, 64, 64);

            return des;
        }

        // ks = 40. bs = 64
        public static SymmetricAlgorithm GetRC2(
            FormData parameters,
            byte[] salt,
            CipherMode mode)
        {
            RC2 rc2 = RC2.Create();
            rc2.Mode = mode;
            var key = new Rfc2898DeriveBytes(parameters.Password,
                salt, 50000);
            rc2.SetAlgProps(key, 40, 64);

            return rc2;
        }

        public static SymmetricAlgorithm Get3DES(
            FormData parameters,
            byte[] salt,
            CipherMode mode)
        {
            TripleDES tripleDES = TripleDES.Create();
            tripleDES.Mode = mode;
            var key = new Rfc2898DeriveBytes(parameters.Password,
                salt, 50000);
            tripleDES.SetAlgProps(key, 192, 64);

            return tripleDES;
        }

        private static void SetAlgProps(this SymmetricAlgorithm algorithm, Rfc2898DeriveBytes key,  int keySize, int blockSize)
        {
            algorithm.KeySize = keySize;
            algorithm.BlockSize = blockSize;
            algorithm.Padding = PaddingMode.PKCS7;

            algorithm.Key = key.GetBytes(algorithm.KeySize / 8);
            algorithm.IV = key.GetBytes(algorithm.BlockSize / 8);
        }

    }
}
