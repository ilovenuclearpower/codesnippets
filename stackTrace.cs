/*
 * C# Program to Create an Instance of StackTrace and to Get all Frames
 */
 // A stacktrace is an inherently useful object for troubleshooting/awareness purposes.
 
using System.Diagnostics;
using System;
using System.IO;
class program
{
    public static void Main()
    {
        StackTrace stackTrace = new StackTrace();           
        StackFrame[] stackFrames = stackTrace.GetFrames();  
        // write call stack method names
        Console.WriteLine("Method Names : ");
        // if you want to write to a file 
        // File fs = CreateFile(path);
        // StreamWriter sw = new StreamWriter(path);
        foreach (StackFrame stackFrame in stackFrames)
        {
            //sw.WriteLine(stackFrame.GetMethod().Name);
            //Will output the string method names from IL to the file for later consumption.
            Console.WriteLine(stackFrame.GetMethod().Name);   
        }
        Console.Read();
    }
}

//Taken from:https://www.sanfoundry.com/csharp-program-generate-fibonocci-series/
