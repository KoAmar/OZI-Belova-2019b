using System;
using CipherLib;

namespace Lab2_decrypt
{
    static class Decrypt
    {
        static void Main()
        {
            Console.Write("Input your`s CipherText : ");
            var cipherText = Console.ReadLine();
            if (!Alphabet.IsAlphabet(cipherText))
            {
                Console.WriteLine("Message has non-alphabet characters!");
                return;
            }

            Console.Write("Input your`s key: ");
            var strKey = Console.ReadLine();
            if (!Alphabet.IsAlphabet(strKey))
            {
                Console.WriteLine("Key has non-alphabet characters!");
                return;
            }

            var key = new Key(strKey);
            var message = Cipher.Decrypt(cipherText, key);

            Console.WriteLine($"Message = {message}");
        }
    }
}
