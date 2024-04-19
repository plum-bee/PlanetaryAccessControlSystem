using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PlanetAccessApp
{
    public class PlanetUtils
    {
        private static readonly char[] Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
        private static readonly int CodeLength = 12;

        public static string GenerateValidationCode()
        {
            var provider = new RNGCryptoServiceProvider();
            byte[] byteArray = new byte[4];
            provider.GetBytes(byteArray);

            int randomSeed = BitConverter.ToInt32(byteArray, 0);
            Random random = new Random(randomSeed);

            char[] codeCharacters = new char[CodeLength];
            for (int i = 0; i < CodeLength; i++)
            {
                int index = random.Next(Characters.Length);
                codeCharacters[i] = Characters[index];
            }

            return new string(codeCharacters);
        }
    }
}

