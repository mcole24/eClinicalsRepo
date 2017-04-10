using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace eClinicals.Utils
{
    class RegExCheckUtil
    {
        static string _usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
        static string _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";
        private static String states = "|AL|AK|AS|AZ|AR|CA|CO|CT|DE|DC|FM|FL|GA|GU|HI|ID|IL|IN|IA|KS|KY|LA|ME|MH|MD|MA|MI|MN|MS|MO|MT|NE|NV|NH|NJ|NM|NY|NC|ND|MP|OH|OK|OR|PW|PA|PR|RI|SC|SD|TN|TX|UT|VT|VI|VA|WA|WV|WI|WY|";
        private static String phoneReg = @"^[\\(]{0,1}([0-9]){3}[\\)]{0,1}[ ]?([^0-1]){1}([0-9]){2}[ ]?[-]?[ ]?([0-9]){4}[ ]*((x){0,1}([0-9]){1,5}){0,1}$";
        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, phoneReg).Success;
        }      
        public static bool IsSSN(string number)
        {
            return Regex.Match(number, @"^(\d{3}-\d{2}-\d{4})|(\d{3}\d{2}\d{4})$").Success;
        }
        public static bool isStateAbbreviation(String state)
        {
            return state.Length == 2 && states.IndexOf(state) > 0;
        }
        public static bool IsUsorCanadianZipCode(string zipCode)
        {
            bool validZipCode = true;
            if ((!Regex.Match(zipCode, _usZipRegEx).Success) && (!Regex.Match(zipCode, _caZipRegEx).Success))
            {
                validZipCode = false;
            }
            return validZipCode;
        }



    }
}
