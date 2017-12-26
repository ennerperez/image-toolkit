using System;
using System.Collections.Generic;

#if !PORTABLE

using System.Security.Cryptography;

#endif

using System.Text;
using System.Text.RegularExpressions;

namespace Platform.Support
{
#if PORTABLE
    namespace Core
    {
#endif

    public static class StringHelper
    {
        public static bool IsNumeric(string expression)
        {
            bool hasDecimal = false;
            for (int i = 0; i < expression.Length; i++)
            {
                // Check for decimal
                if (expression[i] == '.')
                {
                    if (hasDecimal) // 2nd decimal
                        return false;
                    else // 1st decimal
                    {
                        // inform loop decimal found and continue
                        hasDecimal = true;
                        continue;
                    }
                }
                // check if number
                if (!char.IsNumber(expression[i]))
                    return false;
            }
            return true;
        }

        public static bool IsEmail(string expression)
        {
            return Regex.IsMatch(expression, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
        }

        public static string ToSentence(string obj, bool capitalize = false)
        {
            if (capitalize)
            {
                List<string> _return = new List<string>();
                foreach (string Item in obj.Split(' '))
                {
                    _return.Add(Item.ToSentence());
                }
                return String.Join(" ", _return);
            }
            else
            {
                return obj.Substring(0, 1).ToUpper() + obj.Substring(1).ToLower();
            }
        }

#if !PORTABLE

        public static string SHA256(string str, string key = null)
        {
            string result;
            var expr_05 = new UTF8Encoding();
            byte[] bytes2 = expr_05.GetBytes(str);
            var hMAC = new HMACSHA256();
            if (!string.IsNullOrEmpty(key))
            {
                byte[] bytes = expr_05.GetBytes(key);
                hMAC = new HMACSHA256(bytes);
            }

            result = BitConverter.ToString(hMAC.ComputeHash(bytes2)).Replace("-", "").ToLower();

            hMAC.Dispose();

            return result;
        }

        public static string MD5(string str, string key = null)
        {
            string result;
            var expr_05 = new UTF8Encoding();
            byte[] bytes2 = expr_05.GetBytes(str);
            var hMAC = new HMACMD5();
            if (!string.IsNullOrEmpty(key))
            {
                byte[] bytes = expr_05.GetBytes(key);
                hMAC = new HMACMD5(bytes);
            }

            result = BitConverter.ToString(hMAC.ComputeHash(bytes2)).Replace("-", "").ToLower();

            hMAC.Dispose();

            return result;
        }

#endif
    }

#if PORTABLE
    }
#endif
}