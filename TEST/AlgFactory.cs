using SymmetricAlgorithms_Ignatev.TEST;
using System.Security.Cryptography;

namespace SymmetricAlgorithms_Ignatev // твой неймспейс
{
    public static class AlgFactory
    {
        // ks = 256. bs = 128
        public static SymmetricAlgorithm GetAES(
            CipherMode mode)
        {
            var aes = new RijndaelManaged();
            aes.Mode = mode;
            aes.SetAlgProps(256, 128);
            return aes;
        }

        // ks = 64. bs = 64
        public static SymmetricAlgorithm GetDES(
            CipherMode mode)
        {
            DES des = DES.Create();
            des.Mode = mode;
            des.SetAlgProps(64, 64);

            return des;
        }

        // ks = 40. bs = 64
        public static SymmetricAlgorithm GetRC2(
            CipherMode mode)
        {
            RC2 rc2 = RC2.Create();
            rc2.Mode = mode;
            rc2.SetAlgProps(40, 64);

            return rc2;
        }

        public static SymmetricAlgorithm Get3DES(
            CipherMode mode)
        {
            TripleDES tripleDES = TripleDES.Create();
            tripleDES.Mode = mode;
            tripleDES.SetAlgProps(192, 64);

            return tripleDES;
        }
    }
}
