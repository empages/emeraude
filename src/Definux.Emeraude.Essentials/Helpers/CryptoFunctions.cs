using System.Security.Cryptography;
using System.Text;

namespace Definux.Emeraude.Essentials.Helpers
{
    /// <summary>
    /// Functions for cryptography.
    /// </summary>
    public static class CryptoFunctions
    {
        /// <summary>
        /// Generate MD5 hash from string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string MD5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}