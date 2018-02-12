using System;

namespace MF_SrvSTP
{
    class StringUtils
    {
        public static string trimToEmpty(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return String.Empty;
            }
            else
            {
                return str.Trim();
            }
        }
    }
}
