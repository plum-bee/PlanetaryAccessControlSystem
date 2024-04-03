using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class SecureRandom
    {
        private static readonly RNGCryptoServiceProvider _csp = new RNGCryptoServiceProvider();

        public static int Next(int minValue, int maxValue)
        {
            if (minValue >= maxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(minValue), "minValue must be lower than maxValue");
            }

            byte[] byteArray = new byte[4];
            _csp.GetBytes(byteArray);

            int randomSeed = BitConverter.ToInt32(byteArray, 0);
            Random random = new Random(randomSeed);

            return random.Next(minValue, maxValue);
        }
    }
}
