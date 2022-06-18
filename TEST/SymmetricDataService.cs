﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricAlgorithms_Ignatev.TEST
{
    /// <summary>
    /// Сервис получения данных для
    /// сравнительного анализа
    /// симметричных алгоритмов шифрования
    /// </summary>
    public class SymmetricDataService
    {
        private readonly AlgRun _algRun;
        private readonly Stopwatch _stopwatch;


        public SymmetricDataService()
        {
            _stopwatch = new Stopwatch();
            _algRun = new AlgRun();
        }

        /// <summary>
        /// Получение сравнительных данных шифрования
        /// </summary>
        /// <param name="algorithmParameters">Параметры шифрования</param>
        /// <returns>Список моделей с результатами сравнения</returns>
        public async Task<List<AlgorithmResultModel>> GetAlgorithmResults(FormData algorithmParameters)
        {
            var results = new List<AlgorithmResultModel>();
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case (int)AlgEnm.DES:
                            var salt = AlgorithmHelpers.GenerateRandomSalt();
                            var alg = AlgFactory.GetDES(algorithmParameters,salt,CipherMode.CBC);
                            Run(results, CipherMode.CBC, algorithmParameters, "DES_CBC", "DES_CBC", alg);
                            var alg2 = AlgFactory.GetDES(algorithmParameters, salt, CipherMode.ECB);
                            Run(results, CipherMode.ECB, algorithmParameters, "DES_ECB", "DES_ECB", alg2);
                            break;
                        case (int)AlgEnm.TRIPLE_DES:
                            var saltTRIPLE_DES = AlgorithmHelpers.GenerateRandomSalt();
                            var algTRIPLE_DES = AlgFactory.Get3DES (algorithmParameters, saltTRIPLE_DES, CipherMode.CBC);
                            Run(results, CipherMode.CBC, algorithmParameters, "3DES_CBC", "3DES_CBC", algTRIPLE_DES);
                            var alg2TRIPLE_DES = AlgFactory.Get3DES(algorithmParameters, saltTRIPLE_DES, CipherMode.ECB);
                            Run(results, CipherMode.ECB, algorithmParameters, "3DES_ECB", "3DES_ECB", alg2TRIPLE_DES);
                            break;
                        case (int)AlgEnm.Rijndael:
                            var saltRijndael = AlgorithmHelpers.GenerateRandomSalt();
                            var algRijndael = AlgFactory.GetAES (algorithmParameters, saltRijndael, CipherMode.CBC);
                            Run(results, CipherMode.CBC, algorithmParameters, "Rijndael_CBC", "Rijndael_CBC", algRijndael);
                            var alg2Rijndael = AlgFactory.GetAES(algorithmParameters, saltRijndael, CipherMode.ECB);
                            Run(results, CipherMode.ECB, algorithmParameters, "Rijndael_ECB", "Rijndael_ECB", alg2Rijndael);
                            break;
                        case (int)AlgEnm.RC2:
                            var saltRC2 = AlgorithmHelpers.GenerateRandomSalt();
                            var algRC2 = AlgFactory.GetRC2(algorithmParameters, saltRC2, CipherMode.CBC);
                            Run(results, CipherMode.CBC, algorithmParameters, "RC2_CBC", "RC2_CBC", algRC2);
                            var alg2RC2 = AlgFactory.GetRC2(algorithmParameters, saltRC2, CipherMode.ECB);
                            Run(results, CipherMode.ECB, algorithmParameters, "RC2_ECB", "RC2_ECB", alg2RC2);
                            break;
                        default: break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.Run(() => results);
        }
        private void Run(List<AlgorithmResultModel> results, CipherMode mode,FormData algorithmParameters, string name, string extention, SymmetricAlgorithm SymmetricAlgorithm)
        {
            
            var result = new AlgorithmResultModel();
            result.AlgorithmName = name; 
            result.AlgorithmMode = AlgorithmHelpers.GetStringMode(mode);

            _stopwatch.Start();
            _algRun.Encrypt( algorithmParameters, mode, extention, SymmetricAlgorithm);
            _stopwatch.Stop();
            result.EncryptionTime = RoundToSeconds.Invoke(_stopwatch.ElapsedMilliseconds);

            _stopwatch.Restart();
            _algRun.Decrypt(algorithmParameters, mode, extention, SymmetricAlgorithm);
            _stopwatch.Stop();
            result.DecryptionTime = RoundToSeconds.Invoke(_stopwatch.ElapsedMilliseconds);

            results.Add(result);
        }
        private Func<long, double> RoundToSeconds = (long ms) =>
        {
            return Math.Round((double)ms / 1000, 3);
        };
    }
}