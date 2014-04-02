using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtensions
    {
        public static String[] SplitCamelCase(this string str)
        {
            List<String> strs = new List<string> ();
            List<int> splits = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                    splits.Add(i);
            }

            int splitstart = 0;
            for (int j = 0; j < (splits.Count-1); j++)
            {
                string s = str.Substring(splits[j], splits[j + 1] - splits[j]);
                strs.Add(s);
            }
            strs.Add(str.Substring(splits[splits.Count-1]));
            return strs.ToArray();
        }
        public static String ToCamelCase(this string str, String separator)
        {
            List<String> fragments = new List<string>();
            String[] items = str.Split(separator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (String item in items)
            {
                String fragment = item.Substring(0, 1).ToUpper() + item.Substring(1).ToLower();
                fragments.Add(fragment);
            }
            return String.Join("", fragments);
        }
    }
}
