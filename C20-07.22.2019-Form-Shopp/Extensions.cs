using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C20_07._22._2019_Form_Shopp
{
   static class Extensions
    {
        public static bool CheckInput(string[]arr,string input)
        {
            foreach (var listItem in arr)
            {
                if (listItem == input)
                {
                    return false;
                }

            }
            return true;
        }

        public static string HashPsw(this string psw)
        {
            byte[] btArray = new ASCIIEncoding().GetBytes(psw);
            byte[] hashedArr = new SHA256Managed().ComputeHash(btArray);
            string hashPassword = new ASCIIEncoding().GetString(hashedArr);
            return hashPassword;
        } 
    }
}
