using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryptor
{
    class Decryptor
    {
        public string decryptedStr;
        private long encryptionKey;
        private string seperator, encryptedStr;

        public Decryptor(string encryptedInput, long key, string encryptedStrSeperator)
        {
            encryptionKey = key;
            seperator = encryptedStrSeperator;
            encryptedStr = encryptedInput;

            string[] decryptedChars = new string[seperatedChars().Length];
            for (int i = 0; i < seperatedChars().Length; i++)
            {
                decryptedChars[i] = decryptChar(Int64.Parse(seperatedChars()[i]));
            }

            decryptedStr = string.Join("", decryptedChars);
        }

        string[] seperatedChars()
        {
            return encryptedStr.Split(seperator.ToCharArray()[0]);
        }

        string decryptChar(long encryptedChar)
        {
            encryptedChar /= encryptionKey;
            CryptDictionary dict = new CryptDictionary();
            return dict.DecryptionDict()[encryptedChar];
        }
    }
}
