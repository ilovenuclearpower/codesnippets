using System;  
using System.Text;  
using System.Security.Cryptography;  
//SHA256 (and other hashing functions) are usually critical to security functions. Understanding how to generate them may be important.
//This program implements the basic Sha256 function

namespace HashConsoleApp  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            string plainData = "Mahesh";  
            Console.WriteLine("Raw data: {0}", plainData);  
            string hashedData = ComputeSha256Hash(plainData);  
            Console.WriteLine("Hash {0}", hashedData);  
            Console.WriteLine(ComputeSha256Hash("Mahesh"));  
            Console.ReadLine();  
            //Driver function.
        }  
  
        static string ComputeSha256Hash(string rawData)  
        {  
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())  
            //Instantiates a SHA256 Object, in which the ComputeHash method is defined.
            {  
                // ComputeHash - returns byte array (Comments original to C Sharp Corner) 
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  
  
                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();  
                //Class designed to allow logical manipulation of strings (getting around immutable strings)
                for (int i = 0; i < bytes.Length; i++)  
                {  
                    builder.Append(bytes[i].ToString("x2")); 
                    //Appends the bytes as a hexadecimal value.
                }  
                return builder.ToString();  
            }  
        }  
                 
    }  
  
}  

//Taken from https://www.c-sharpcorner.com/article/compute-sha256-hash-in-c-sharp/
