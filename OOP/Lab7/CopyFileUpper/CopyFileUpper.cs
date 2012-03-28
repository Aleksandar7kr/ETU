using System;
using System.IO;

public class CopyFileUpper
{
    public static void Main()
	{
        string inFileName;
        string outFileName;

        StreamReader inFile;
        StreamWriter outFile;

        Console.WriteLine("Please enter the name of input file:");
        inFileName = Console.ReadLine();

        Console.WriteLine("Please enter the name of output file");
        outFileName = Console.ReadLine();

        try
        {
            inFile = new StreamReader(inFileName);
            outFile = new StreamWriter(outFileName);
            string buffer = "";

            while(inFile.Peek() != -1)
            {
                buffer += inFile.ReadLine();
                outFile.WriteLine(buffer.ToUpper());
                buffer = "";
            }

            inFile.Close();
            outFile.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        Console.ReadKey();
	}       
}
