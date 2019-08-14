using System;
using System.Text;

namespace RESTfulstructure.Core.Authentication
{
    public class VigenereCipher
    {
        private string _key;
        private string _encoded;
        private string _decoded;

        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        public string Encoded
        {
            get { return Encode(); }
            set { _encoded = value; }
        }

        public string Decoded
        {
            get { return Decode(); }
            set { _decoded = value; }
        }

        public VigenereCipher()
        {
        }

        public VigenereCipher(string key)
        {
            _key = key;
        }

        private char Trans(char ch, byte k)
        {
            byte[] b = new byte[1];
            b[0] = (byte)((256 + Encoding.UTF7.GetBytes(ch.ToString())[0] + k) % 256);
            return Encoding.UTF7.GetChars(b)[0];
        }

        private string Encode()
        {
            int j = 1;
            int size = _decoded.Length;
            char[] buf = new char[size];
            var _encodedArray = _decoded.ToCharArray();

            if ((_key != "") && (size > 0))
            {
                for (int i = 0; i < size; i++)
                {
                    buf[i] = Trans(_encodedArray[i], (byte)_key[j - 1]);
                    j = (j % _key.Length) + 1;
                }

                return new string(buf);
            }
            else
            {
                return string.Empty;
            }
        }

        private string Decode()
        {
            int j = 1;
            int size = _encoded.Length;
            char[] buf = new char[size];
            var _encodedArray = _encoded.ToCharArray();

            if ((_key != "") && (size > 0))
            {
                for (int i = 0; i < size; i++)
                {
                    buf[i] = Trans(_encodedArray[i], (byte)(-1 * (int)_key[j - 1]));
                    j = (j % _key.Length) + 1;
                }

                return new string(buf);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
