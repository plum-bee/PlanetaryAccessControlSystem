using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecureRandom
{
    public class RandomGenerator
    {
        readonly RNGCryptoServiceProvider _csp;

        public RandomGenerator()
        {
            _csp = new RNGCryptoServiceProvider();
        }

        public int Next(int minValue, int maxValue)
        {
            if (minValue >= maxValue)
            {
                throw new ArgumentOutOfRangeException("minValue must be lower than maxValue");
            }
            else
            {
                byte[] byteArray = new byte[4];
                _csp.GetBytes(byteArray);

                int randomSeed = BitConverter.ToInt32(byteArray, 0);
                Random random = new Random(randomSeed);

                return random.Next(minValue, maxValue);
            }
        }
    }
}
