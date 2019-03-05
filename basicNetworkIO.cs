/*
 * C# Program to Accept an Employee Name from Client and Sends back the Employee   
 * Job using XML
 */
 // Network traffic
//SERVER SIDE PROGRAM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Configuration;
namespace ServerSocket
{
    class Program
    {
        static TcpListener listener;
        const int LIMIT = 5; 
        public static void Service()
        // Initializes your listener.
        {
            while (true)
            {
                Socket soc = listener.AcceptSocket();
                //Creates a new socket to listen to stuff over a given port.
                Console.WriteLine("Connected: {0}", soc.RemoteEndPoint);
                try
                {
                    Stream s = new NetworkStream(soc);
                    //Generates a network stream listening on the port in soc.
                    StreamReader sr = new StreamReader(s);
                    StreamWriter sw = new StreamWriter(s);
                    //Allows you to read and write from the stream.
                    sw.AutoFlush = true; // enable automatic flushing
                    sw.WriteLine("{0} Employees available", 
                                 ConfigurationSettings.AppSettings.Count);
                    while (true)
                    {
                        string name = sr.ReadLine();
                        if (name == "" || name == null) break;
                        string job = ConfigurationSettings.AppSettings[name];
                        //Pulls the job from the configuration file based on employeename
                        if (job == null) job = "No such employee";
                        sw.WriteLine(job);
                        //Writes the job back to the stream, allowing querying for employees jobs by name.
                        //Listens to the stream for incoming inputs.
                    }
                    s.Close();
                    //Shuts the stream.
                }
                catch (Exception e)
                {
 
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Disconnected: {0}", soc.RemoteEndPoint);
                soc.Close();
                //Shuts the socket after an error.
            }
        }
       static void Main(string[] args)
        {
            //Initializes listener on port 2055.
            listener = new TcpListener(2055);
            listener.Start();
 
            Console.WriteLine("Server mounted, listening to port 2055");
            for (int i = 0; i < LIMIT; i++)
            {
                Thread t = new Thread(new ThreadStart(Service));
                t.Start();
            }
            //Starts five new threads to listen for inputs.
            //Driver program.
        }
    }
}
//XML CODING
 
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <add key = "mickey" value="manager"/>
    <add key = "bob" value="tester"/>
    <add key = "tom" value="clerk"/>
    <add key = "jerry" value="manager"/>
  </appSettings>
</configuration>
 //Config file to include all of the employees.
//CLIENT SIDE PROGRAM
//XML file that contains your employee name keys and job values.
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Sockets;
namespace ClientSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("win7-PC", 2055);
            //Initializes the tcp/ip client.
            try
            {
                Stream s = client.GetStream();
                StreamReader sr = new StreamReader(s);
                StreamWriter sw = new StreamWriter(s);
                //Builds the stream and read/write capabilities.
                sw.AutoFlush = true;
                Console.WriteLine(sr.ReadLine());
                while (true)
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    sw.WriteLine(name);
                    if (name == "") break;
                    Console.WriteLine(sr.ReadLine());
                }
                //Queries for the name.
                s.Close();
            }
            finally
            {
                client.Close();
            } 
 
        }
    }
}
//Taken from: https://www.sanfoundry.com/csharp-program-employee-name-Xml/
