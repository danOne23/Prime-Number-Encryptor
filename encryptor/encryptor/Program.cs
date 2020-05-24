using System;

namespace encryptor
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nPhrase\n");
                string input = Console.ReadLine();

                Console.WriteLine("\nEncryptionKey\n");
                long key = Int64.Parse(Console.ReadLine());

                Console.WriteLine("\nSeperator\n");
                string seperator = Console.ReadLine();

                Console.WriteLine("\nChoose an action\n1) Encrypt\n2) Decrypt\n");
                string action = Console.ReadLine();

                string output;
                if (action == "1")
                {
                    Encryptor encryptor = new Encryptor(input, key, seperator);
                    output = encryptor.encryptedStr;
                }
                else if (action == "2")
                {
                    Decryptor decryptor = new Decryptor(input, key, seperator);
                    output = decryptor.decryptedStr;
                }
                else output = "error";

                Console.WriteLine("\n{0}\n", output);
            }
        }
    }
}
