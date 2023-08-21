﻿using SignatureLib;
using System;
using System.IO;
using System.Security.Cryptography;

namespace SignatureLib
{
    public class SignatureClassLib
    {
        const string PUBLICPRIVATEKEY = "C:\\Users\\coled\\Desktop\\Chapter 5\\SignatureApp\\Files\\CollinsPublicPrivateKey.xml";
        const string PUBLICONLYKEY = "C:\\Users\\coled\\Desktop\\Chapter 5\\SignatureApp\\Files\\CollinsPublicOnlyKey.xml";

        public static void GenerateNewKeys()
        {
            //establish RSA asymmetric algorithm
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //provide public and private RSA params
            StreamWriter writer = new StreamWriter(PUBLICPRIVATEKEY);
            string publicPrivateKeyXML = rsa.ToXmlString(true);
            writer.Write(publicPrivateKeyXML);
            writer.Close();

            //provide public only RSA params
            writer = new StreamWriter(PUBLICONLYKEY);
            string publicOnlyKeyXML = rsa.ToXmlString(false);
            writer.Write(publicOnlyKeyXML);
            writer.Close();
        }

        public static void SignFile(String sourceFile, String destFile)
        {
            // Copy the contents of the sourceFile to the destFile
            if (File.Exists(destFile))
                File.Delete(destFile);
            File.Copy(sourceFile, destFile);

            // Create file streams for sourceFile and destFile (signed message)
            FileStream inStream = new FileStream(sourceFile, FileMode.Open);
            FileStream outStream = new FileStream(destFile, FileMode.Append, FileAccess.Write);

            // Compute the hash of the sourceFile
            // **** Insert code to Create SHA256 ***************************
            SHA256 mySHA256 = SHA256Managed.Create();
            // **** Insert code to compute SHA256 hash and store result in byte[] hashValue
            byte[] hashValue = mySHA256.ComputeHash(inStream);

            // Create RSA object using default key
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //read private RSA parameters for encrypt
            StreamReader readKey = new StreamReader(PUBLICPRIVATEKEY);
            string publicPrivateKeyXML = readKey.ReadToEnd();
            rsa.FromXmlString(publicPrivateKeyXML);
            readKey.Close();

            // Sign hash using OID for SHA256
            // **** Insert code to SignHash for rsa object store result in byte[] signatureBytes
            byte[] signatureBytes = rsa.SignData(hashValue, mySHA256);

            // Write Signature to end of destFile
            outStream.Write(signatureBytes, 0, signatureBytes.Length);

            // Write the public key to end of destFile
            StreamWriter writer = new StreamWriter(outStream);
            string publicKeyXML = rsa.ToXmlString(false);
            writer.Write(publicKeyXML);

            // Done writing, close the streams
            writer.Close(); outStream.Close(); inStream.Close();
            return;
        }

        public static bool VerifySignedFile(String sourceFile)
        {
            // Create stream for signed file
            FileStream inStream = new FileStream(sourceFile, FileMode.Open);

            // Store contents of sourceFile into byte array
            int[] byteIn = new int[inStream.Length];
            int i;
            for (i = 0; i < inStream.Length; i++)
                byteIn[i] = inStream.ReadByte();

            // Locate beginning of public XML parameters (starts with <RSA)
            // Start searching at the end of the byte array
            i--;
            while (!((char)byteIn[i - 3] == '<' && (char)byteIn[i - 2] == 'R' &&
                    (char)byteIn[i - 1] == 'S' && (char)byteIn[i] == 'A'))
                i--;

            // i points to the 'A' in "<RSA", position of the '<' is left 3 
            int publicKeyXMLstart = i - 3;

            // Read public key and store into new RSA object
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            inStream.Position = publicKeyXMLstart;
            StreamReader readKey = new StreamReader(inStream);
            string publicKeyXML = readKey.ReadToEnd();
            // **** Insert code to store publicKeyXML in rsa object
            rsa.FromXmlString(publicKeyXML);

            // Locate beginning of signature in sourcFile
            // All SHA signatures (SHA1, 256, 384, and 512) are always 128 bytes
            // Signature hash starts 128 bytes before public key
            int signatureBytesStart = publicKeyXMLstart - 128;

            // Store signature in byte array
            byte[] signatureBytes = new byte[128];
            // **** Insert code to set the position of inStream to signatureBytesStart
            inStream.Position = signatureBytesStart;
            inStream.Read(signatureBytes, 0, 128);

            // Determine length of message in sourceFile
            // Message length is equal to file length - public key - signature
            // SHA signaturess are always 128 bytes
            int messageLength = (int)inStream.Length - publicKeyXML.Length - 128;

            // Read message into byte array
            byte[] messageByte = new byte[messageLength];
            inStream.Position = 0;
            inStream.Read(messageByte, 0, messageLength);

            // Compute hash on message
            SHA256 sha = new SHA256Managed();
            // **** Insert code to compute a hash on messageByte, 

            // **** store result in byte[] computedHashBytes            
            byte[] computedHashBytes = sha.ComputeHash(messageByte);
            // Verify signature
            // **** Insert code to call VerifyHash for the rsa object result 
            // **** should be placed in bool match
            bool match = rsa.VerifyHash(
                computedHashBytes, "2.16.840.1.101.3.4.2.1", signatureBytes);

            // compare the computed hash with the stored value
            String strResult;
            if (match)
                strResult = "VerifySignature returned TRUE";
            else
                strResult = "VerifySignature returned FALSE";
            Console.WriteLine("{0}", strResult);
            return match;
        }
    }
}

namespace HashApp
{
    class HashApp
    {
        const string MESSAGEFILE = "C:\\Users\\coled\\Desktop\\Signature\\StudentFile.txt";
        const string SIGNEDFILE = "C:\\Users\\coled\\Desktop\\Signature\\CunninghamSignatureAssignment.txt";

        static void Main(string[] args)
        {
            // to view the signed files use Wordpad, not Notepad
            SignatureClassLib.GenerateNewKeys();
            SignatureClassLib.SignFile(MESSAGEFILE, SIGNEDFILE);
            SignatureClassLib.VerifySignedFile(SIGNEDFILE);
        }
    }
}