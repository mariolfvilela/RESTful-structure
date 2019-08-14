using System;
namespace RESTfulstructure.Core.Authentication
{
    public class Encrypt
    {
        public static string EncodePassword(string password)
        {
            VigenereCipher vigenereCipher = new VigenereCipher("LifeSys");

            vigenereCipher.Decoded = password;
            return vigenereCipher.Encoded;
        }
    }
}
