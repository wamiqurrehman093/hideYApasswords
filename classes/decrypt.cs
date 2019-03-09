using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace encryterConsole
{
    class decrypt
    {
        public string funcDecrypt(string s, Dictionary<char, char> x)
        {
            string retDecrypt = "";
            for (int i = 0; i < s.Length; i++)
            {
                
                if (x.ContainsKey(s[i]))
                {

                    char result = x.Keys.FirstOrDefault(t => x[t] == s[i]);
                    retDecrypt = retDecrypt+result;

                }

            }

            return retDecrypt;
        }
    }
}
