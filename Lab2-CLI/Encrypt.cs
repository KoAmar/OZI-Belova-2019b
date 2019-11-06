using System;

namespace CipherLib
{
    class Encrypt
    {
        public static void Main(string[] args)
        {
            Console.Write("Input your`s message: ");
            var message = Console.ReadLine();
            if(!Alphabet.IsAlphabet(message))
            {
                Console.WriteLine("Message has non-alphabet characters!");
                return;
            }

            Console.Write("Input your`s key: ");
            var strKey = Console.ReadLine();
            if(!Alphabet.IsAlphabet(strKey))
            {
                Console.WriteLine("Key has non-alphabet characters!");
                return;
            }

            var key = new Key(strKey);
            var cipherText = Cipher.Encrypt(message, key);

            Console.WriteLine($"CipherText = {cipherText}");
            var text = Cipher.Decrypt(cipherText, key);

            Console.WriteLine($"Message = {text}");
        }
    }
}