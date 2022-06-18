using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricAlgorithms_Ignatev.TEST
{
    public class AlgRun
    {
        public void Encrypt(FormData formdata,CipherMode  mode, string extention,SymmetricAlgorithm SymmetricAlgorithm)
        {
            var salt = AlgorithmHelpers.GenerateRandomSalt();
            SymmetricAlgorithm.SetAlgKey(formdata.Password, salt);
            string encryptedFilePath = formdata.FilePath + extention;

            using (SymmetricAlgorithm algorithm = SymmetricAlgorithm)
            using (var outputStream = new FileStream(encryptedFilePath, FileMode.Create))
            {
                outputStream.Write(salt, 0, salt.Length);

                using (var inputStream = new FileStream(formdata.FilePath, FileMode.Open))
                using (var cryptoStream = new CryptoStream(outputStream, algorithm.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    byte[] buffer = new byte[1024];
                    int read;
                    try
                    {
                        while ((read = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            cryptoStream.Write(buffer, 0, read);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
        public void Decrypt(FormData formdata, CipherMode mode, string extention, SymmetricAlgorithm SymmetricAlgorithm)
            {
            byte[] salt = new byte[32];
            string encryptedFilePath = formdata.FilePath + extention;

            using (var inputStream = new FileStream(encryptedFilePath, FileMode.Open))
            {
                inputStream.Read(salt, 0, salt.Length);
                SymmetricAlgorithm.SetAlgKey(formdata.Password, salt); // вот тут надо было солить
                using (var algorithm = SymmetricAlgorithm)
                using (var cryptoStream = new CryptoStream(inputStream, algorithm.CreateDecryptor(), CryptoStreamMode.Read))
                using (var outputStream = new FileStream(formdata.FilePath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024];
                    int read;
                    try
                    {
                        while ((read = cryptoStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            outputStream.Write(buffer, 0, read);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}
