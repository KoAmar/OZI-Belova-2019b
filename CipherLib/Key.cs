using System;
using System.Diagnostics;

namespace CipherLib
{
    public class Key
    {
        private readonly string _keyText;

        public Key(string keyText)
        {
            _keyText = keyText ?? throw new ArgumentNullException(nameof(keyText));
        }

        public int GetLetterIndex(int num)
        {   
            var number = num % _keyText.Length;
            Debug.WriteLine($"KeyLetter: {_keyText[number]}");
            return Alphabet.GetAlphabetIndex(_keyText[number]);
        }
    }
}