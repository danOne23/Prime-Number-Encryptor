using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryptor
{
    class Encryptor
    {
        public string encryptedStr { get; }
        private long encryptionKey;
        private string inputStr, charSeperator;

        public Encryptor(string input, long key, string seperator)
        {
            encryptionKey = key;
            inputStr = input;
            charSeperator = seperator;
            encryptedStr = encrypt();
        }

        string encrypt() // Encrypt input
        {

            char[] charArr = inputStr.ToCharArray();
            int nrOfChars = charArr.Length;
            string[] encryptedValue = new string[nrOfChars];

            for (int i = 0; i < nrOfChars; i++)
            {
                long encryptedChar = encryptCharacter(charArr[i]);
                encryptedChar *= encryptionKey;
                encryptedValue[i] = encryptedChar.ToString();
            }

            return string.Join(charSeperator, encryptedValue);
        }

        long encryptCharacter(char ch) // Encrypt a character
        {
            string _ch = ch.ToString().ToLower();
            CryptDictionary dict = new CryptDictionary();
            return dict.encryptionDict()[_ch];
        }
    }
}
