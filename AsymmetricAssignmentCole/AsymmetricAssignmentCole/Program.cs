using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace AsymmetricAssignmentCole
{
    class Program
    {
        static void Main(string[] args)
        {
            string EncryptedText = "C:/Users/coled/Desktop/Asymmetric/RijndaelSecretKeyEncrypted.txt";
            string SecretKey = "C:/Users/coled/Desktop/Asymmetric/RijndaelSecretKeyEncrypted.txt";
            string CipherText = "C:/Users/coled/Desktop/Asymmetric/CipherTextFile.txt";
            string IVInfo = "C:/Users/coled/Desktop/Asymmetric//RijndaelIvInfo.txt";
            string fileOut = "C:/Users/coled/Desktop/Asymmetric/CunninghamRecoveredText.docx";
            string publicKey = "C:/Users/coled/Desktop/Asymmetric/StudentPublicPrivateKey.xml";


            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            //Decrpyting Encrypted File
            FileStream fin = File.OpenRead(SecretKey);
            byte[] cipherBytes = new byte[fin.Length];
            fin.Read(cipherBytes, 0, cipherBytes.Length);
            fin.Close();

            //decrypt byte array using OAEP padding
            // decrypt cipherbytes and store into byte array newPlainText
            StreamReader reader = new StreamReader(publicKey);
            string RSAPublicPrivateKeyXML = reader.ReadToEnd();
            reader.Close();
            rsa.FromXmlString(RSAPublicPrivateKeyXML);
            byte[] decryptedKey = rsa.Decrypt(cipherBytes, true);

            FileStream fsIVIn = new FileStream(IVInfo, FileMode.Open, FileAccess.Read);
            byte[] byteArrayIV = new byte[fsIVIn.Length];
            fsIVIn.Read(byteArrayIV, 0, (int)fsIVIn.Length);
            byte[] iv = byteArrayIV;

            FileStream CipherTextIn = new FileStream(CipherText, FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(fileOut, FileMode.Create, FileAccess.Write);

            Rijndael alg = Rijndael.Create();

            alg.Key = decryptedKey;
            alg.IV = iv;

            CryptoStream cs = new CryptoStream(
            fsOut, alg.CreateDecryptor(), CryptoStreamMode.Write);

            // Encrypt one byte at a time 
            int ByteData;
            while ((ByteData = CipherTextIn.ReadByte()) != -1)
                cs.WriteByte((byte)ByteData);

            cs.Clear(); //this will also close fsOut;
            cs.Close(); CipherTextIn.Close();
        }
    }
}
