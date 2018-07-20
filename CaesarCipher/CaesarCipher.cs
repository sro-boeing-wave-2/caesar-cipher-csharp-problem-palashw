using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string ciphertext = "";

            foreach (char c in text)
            {
                if(alphabet.Contains(c.ToString().ToLower()) == false)
                {
                    ciphertext += c;
                }
                else if(alphabet.IndexOf(c.ToString().ToLower()) + shiftKey > 25)
                {
                    ciphertext += char.IsUpper(c) ? alphabet[alphabet.IndexOf(c.ToString().ToLower()) + shiftKey - 26].ToString().ToUpper(): alphabet[alphabet.IndexOf(c.ToString().ToLower()) + shiftKey - 26].ToString();
                }
                else
                {
                    ciphertext += char.IsUpper(c) ? alphabet[alphabet.IndexOf(c.ToString().ToLower()) + shiftKey].ToString().ToUpper(): alphabet[alphabet.IndexOf(c.ToString().ToLower()) + shiftKey].ToString();
                }
            }
            
            return ciphertext;

        }
    }
}
