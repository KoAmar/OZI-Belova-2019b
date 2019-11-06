using System;
using System.Diagnostics;
using System.Text;

namespace CipherLib
{
    public static class Cipher
    {
        public static string Encrypt(string message, Key key)
        {
            var cipherText = new StringBuilder();
            var letterNum = 0;
            foreach(var letter in message)
            {
                cipherText.Append(Alphabet.GetChar(
                    (Alphabet.GetAlphabetIndex(letter) + key.GetLetterIndex(letterNum)) % Alphabet.AlphabetString.Length
                    ));
                letterNum++;
            }

            return cipherText.ToString();
        }

        public static string Decrypt(string cipherText, Key key)
        {
            var message = new StringBuilder();
            var letterNum = 0;
            foreach(var letter in cipherText)
            {   
                var alphabetIndex = Alphabet.GetAlphabetIndex(letter);
                var letterIndex = key.GetLetterIndex(letterNum);
                
                Debug.WriteLine($"{letterNum}:");                
                Debug.WriteLine($"  Alphabet.GetAlphabetIndex: {alphabetIndex} - key.GetLetterIndex: {letterIndex}");

                var diff = alphabetIndex - letterIndex;
                Debug.WriteLine($"    Diff: {diff}");

                message.Append(Alphabet.GetChar(
                    diff % 26
                    ));
                letterNum++;
            }

            return message.ToString();
        }
    }
}
