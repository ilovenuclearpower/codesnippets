/*
 * C# Program to Read Lines from a File until the End of File is Reached
 */
using System;
using System.IO;
class Test
{
    public static void Main()
    {
        string path = @"c:\sri\srip.txt";
        try
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                //Deletes the file at the path if it exists.
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("This");
                sw.WriteLine("text is");
                sw.WriteLine("to test");
                sw.WriteLine("Reading");
            }
            //Creates the file at the path.
 
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                //sr.Peek() will return -1 when EOF is reached.
                {
                    Console.WriteLine(sr.ReadLine());
                    //Outputs the next line until it hits EOF
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
            //Error checking.
        }
        Console.Read();
    }
}

// Taken from: https://www.sanfoundry.com/csharp-program-read-lines-until-end-file/
