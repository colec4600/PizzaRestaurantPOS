// Same as EncryptedHash except it
// Computes a hash from a data file

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text; // needed for string conversion to byte array

public class EncryptedHash
{
    const string INPUTFILENAME = "C:\\Users\\coled\\Desktop\\Hash\\hashedText5.txt";
    const string OUTPUTFILE = "//storage2.mssu.edu/DropBox/CIS/Collins/CIS405/Assignments/Hash/CunninghamHashedFile.txt";
    static string password = "asdfghjk";
    static string keyP = "PERSEVERE";

    static void Main(string[] args)
    {
        byte[] salt = Encoding.UTF8.GetBytes("CIS405MSSU");//must be at least 8 bytes
        Rfc2898DeriveBytes pwdGen = new Rfc2898DeriveBytes(password, salt);

        //HMACSHA1 accepts keys of any size, and produces a 160 bit hash
        HMACSHA256 hmacsha = new HMACSHA256();
        hmacsha.Key = pwdGen.GetBytes(hmacsha.Key.Length);

        // Create an array to hold the keyed hash value read from the file:
        byte[] storedHash = new byte[hmacsha.HashSize / 8];
        // create a FileStream for the source file
        FileStream inStream = new FileStream(INPUTFILENAME, FileMode.Open);
        // Read in the storedHash
        
        // Compute the hash of the remaining contents of the file
        // The stream is properly positioned at the beginning of the content, 
        // immediately after the stored hash value
        byte[] computedHash = hmacsha.ComputeHash(inStream);
        inStream.Read(storedHash, 0, storedHash.Length);
        // compare the computed hash with the stored value
        for (int i = 0; i < storedHash.Length; i++)
        {
            if (computedHash[i] != storedHash[i])
            {
                Console.WriteLine("Hash values differ! Encoded file has been tampered with!");
                //return false;
            }
        }
        Console.WriteLine("Hash values agree -- no tampering occurred.");
        inStream.Close();
        //return true;
    }
}