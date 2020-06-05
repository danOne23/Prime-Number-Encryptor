using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encryptor
{

    class Program
    {
        [STAThread]

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static string Encrypt(string input, string key, string seperator) => new Encryptor(input, Int64.Parse(key), seperator).encryptedStr;
        public static string Decrypt(string input, string key, string seperator) => new Decryptor(input, Int64.Parse(key), seperator).decryptedStr;
    }
}
