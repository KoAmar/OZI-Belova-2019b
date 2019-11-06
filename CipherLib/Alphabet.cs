using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace CipherLib
{
    public static class Alphabet
    {
        public const string AlphabetString = "abcdefghijklmnopqrstuvwxyz";
        public static bool IsAlphabet(string text)
        {
            return text != null && text.Any(letter => AlphabetString.Contains(letter));
        }

        public static int GetAlphabetIndex(char letter)
        {   
            var index = AlphabetString.IndexOf(letter);
            return index+1;
        }

        public static char GetChar(int index)
        {   
            //Debug.WriteLine($"    Index: {index}");

            if(index <= 0) index += 26;
            //Debug.WriteLine($"    NewIndex: {index}");
            return AlphabetString[index-1];

        }
    }
}