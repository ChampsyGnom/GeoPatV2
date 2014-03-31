using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Emash.GeoPat.Layers.Shared.Models
{
    public class ConfigurationDatabase
    {
        public String ProviderTypeFullName { get; set; }
        public String DisplayName { get; set; }
        public Dictionary<String, String> Parameters { get; set; }
        public bool IsDefault { get; set; }
        public ConfigurationDatabase()
        {
            this.Parameters = new Dictionary<string, string>();
        }



        public string GetHash()
        {
            String str = this.ProviderTypeFullName;
            foreach (String key in this.Parameters.Keys)
            {str = str + key + this.Parameters[key];}
            return CreateMD5Hash(str);
        }

        public string CreateMD5Hash(string input)
        {
            // Use input string to calculate MD5 hash
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
                // To force the hex string to lower-case letters instead of
                // upper-case, use he following line instead:
                // sb.Append(hashBytes[i].ToString("x2")); 
            }
            return sb.ToString();
        }
    }
}
