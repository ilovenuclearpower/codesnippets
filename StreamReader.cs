using System.IO;

class Program
{
    static void Main()
    {
        // Read every line in the file.
        using (StreamReader reader = new StreamReader("file.txt"))
        // StreamReader uses a byte-wise "seek" type method.
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                //This method will update the value of line, then move the "seek" index
                //in the file to the next line.
                // Do something with the line.
                string[] parts = line.Split(',');
                //My addition:
                //Console.WriteLine(line)
            }
        }
    }
}
//Taken from https://www.dotnetperls.com/file
