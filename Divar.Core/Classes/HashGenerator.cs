using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Divar.Core.Classes
{ 
    public static class  HashGenerator
    {
        public static string EncodingPassWMD5 (string password)
        {
            Byte[] MainBytes;
            Byte[] EncodeByte;
            MD5 md5;

            md5 = new MD5CryptoServiceProvider();
            MainBytes = ASCIIEncoding.Default.GetBytes(password);
            EncodeByte = md5.ComputeHash(MainBytes);

            return BitConverter.ToString(EncodeByte);



        }
    }
}
