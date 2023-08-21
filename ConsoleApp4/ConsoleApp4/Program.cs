using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            const string plainText = "C:/Users/coled/Desktop/CryptoClass/Chapter 3/Assignments/plainText.docx";
            const string recoveredText = "C:/Users/coled/Desktop/CryptoClass/Chapter 3/Assignments/PARTA1.docx";
            const string KEY = "C:/Users/coled/Desktop/CryptoClass/Chapter 3/Assignments/keyInfo.txt";
            const string IVINFO = "C:/Users/coled/Desktop/CryptoClass/Chapter 3/Assignments/ivInfo.txt";

            SymmetricAlgorithm cryptic = TripleDES.Create();

            cryptic.Padding = PaddingMode.ISO10126;
            //cryptic.Mode = CipherMode.CBC;

            FileStream fin = new FileStream(plainText, FileMode.Open, FileAccess.Read);

            FileStream fout = new FileStream(recoveredText, FileMode.OpenOrCreate, FileAccess.Write);

            FileStream fsKeyInfo = new FileStream(
            KEY, FileMode.Open, FileAccess.Read);
            FileStream fsIVInfo = new FileStream(
                IVINFO, FileMode.Open, FileAccess.Read);

            byte[] bin = new byte[100];  //This is intermediate storage for the encryption.
            long rdlen = 0;              //This is the total number of bytes written.
            long totlen = fin.Length;    //This is the total length of the input file.
            int len;

            

            byte[] bytes32 = new byte[cryptic.Key.Length];
            fsKeyInfo.Read(bytes32, 0, cryptic.Key.Length);
            cryptic.Key = bytes32;
            byte[] bytes16 = new byte[cryptic.IV.Length];
            fsIVInfo.Read(bytes16, 0, cryptic.IV.Length);
            cryptic.IV = bytes16;
            fsKeyInfo.Close();
            fsIVInfo.Close();
   

            CryptoStream encStream = new CryptoStream(fout, cryptic.CreateEncryptor(bytes32, bytes16), CryptoStreamMode.Write);

            //StreamReader reader = new StreamReader(decStream, System.Text.Encoding.UTF8);
            while(rdlen < totlen)
            {
                len = fin.Read(bin, 0, 100);
                encStream.Write(bin, 0, len);
                rdlen = rdlen + len;
            }

          



        }
    }
}
