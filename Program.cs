using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


                long key = 1;
                while (true)
                {
                    Console.WriteLine("\nEncryptionKey\n");

                    try
                    {
                        key = Int64.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("\nPlease enter an intiger\n");
                    }
                }

                string seperator;
                while (true)
                {
                    Console.WriteLine("\nSeperator\n");
                    seperator = Console.ReadLine();

                    if (seperator.Length == 1) break;
                    else Console.WriteLine("\nSeperator must be one character long\n");
                }
                

                Console.WriteLine("\nChoose an action\n1) Encrypt\n2) Decrypt\n");
                string action = Console.ReadLine();

                string output;
                if (action == "1")
                {
                    try
                    {
                        Encryptor encryptor = new Encryptor(input, key, seperator);
                        output = encryptor.encryptedStr;
                    }
                    catch (System.Collections.Generic.KeyNotFoundException)
                    {
                        output = "Character not found in Dictionary";
                    }

                }
                else if (action == "2")
                {
                    try
                    {
                        Decryptor decryptor = new Decryptor(input, key, seperator);
                        output = decryptor.decryptedStr;
                    }
                    catch (System.Collections.Generic.KeyNotFoundException)
                    {
                        output = "Character not found in Dictionary";
                    }
                }
                else output = "Invalid option";

                Console.WriteLine("\n{0}\n", output);
            }
        }
    }
}
