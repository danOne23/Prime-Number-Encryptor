using System;
using System.Collections.Generic;
using System.Text;

namespace encryptor
{
    class CryptDictionary
    {

        public Dictionary<string, long> encryptionDict()
        {
            Dictionary<string, long> returnDict = new Dictionary<string, long>();

            for (int i = 0; i < decryptedChars.Length; i++)
            {
                returnDict.Add(decryptedChars[i], encryptedChars[i]);
            }

            return returnDict;
        }

        public Dictionary<long, string> DecryptionDict()
        {
            Dictionary<long, string> returnDict = new Dictionary<long, string>();

            for (int i = 0; i < decryptedChars.Length; i++)
            {
                returnDict.Add(encryptedChars[i], decryptedChars[i]);
            }

            return returnDict;
        }

        private string[] decryptedChars = new string[]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
            "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7",
            "8", "9", " ", "!", "?", ".", ","
        };

        private long[] encryptedChars = new long[] 
        {
            1000000007, 1000000009, 1000000021, 1000000033, 1000000087, 1000000093, 1000000097, 10000000537, 1000000123, 1000000181, 1000000207, 1000000223, 1000000241, 1000000271, 1000000289,
            1000000297, 1000000321, 1000000349, 1000000363, 1000000403, 1000000019, 10000000679, 1000000061, 1000000069, 10000000631, 1000000103, 832583, 832591, 832597, 832607, 832613, 832621,
            832627, 832631, 832633, 832639, 832568003, 832568039, 832568059,832568069, 832568071
        };
    }
}
