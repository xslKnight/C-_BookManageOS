using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xsl_FinalWork
{
    class Identify
    {
        private int getNumRandom()
        {
            return new Random(GetRandomSeed()).Next(0, 9);
        }

        static int GetRandomSeed()

        {

            byte[] bytes = new byte[4];

            System.Security.Cryptography.RNGCryptoServiceProvider r = new System.Security.Cryptography.RNGCryptoServiceProvider();

            r.GetBytes(bytes);

            return BitConverter.ToInt32(bytes, 0);

        }

        private char charRandom()
        {
            int x = new Random(GetRandomSeed()).Next(65, 91);
            char ch= Convert.ToChar(x);
            return ch;


        }
        public String getRandom(int length)
        {
            StringBuilder strBuil = new StringBuilder();
            Random rd = new Random();
            for(int i = 0;i< length; i++)
            {
                if ((rd.NextDouble())*10<5.0)
                {
                    strBuil.Append(getNumRandom());
                }
                else
                {
                    strBuil.Append(charRandom());
                }
            }
            return strBuil.ToString();
        }
    }
}
