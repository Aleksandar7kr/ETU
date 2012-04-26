using System;
using System.IO;

namespace lab5
{
    class FileDetails
    {

        // info strings
        String strVowels = "AEIOUYaeiouy";
        String strConsonants = "QWRTPSDFGHJKLZXCVBNMqwrtpsdfghjklzxcvbnm";

        public void Summ(Char[] contents)
        {
            // counters
            int counterVowels = 0;
            int counterConsonants = 0;

            foreach (char c in contents)
            {
                if (strVowels.IndexOf(c) != -1) counterVowels++;
                if (strConsonants.IndexOf(c) != -1) counterConsonants++;
            }

            Console.WriteLine("");
            Console.WriteLine("Text analyze:");
            Console.WriteLine("all characters: {0}", contents.Length);
            Console.WriteLine("vowels characters: {0}", counterVowels);
            Console.WriteLine("consonants characters: {0}", counterConsonants);
        }

        public static void Main(String [] args)
        {
            try
            {
                if (args.Length != 0)
                {
                    String fileName = args[0];
                    FileStream stream = new FileStream(fileName, FileMode.Open);
                    StreamReader reader = new StreamReader(stream);

                    Console.WriteLine("length of args: {0} ", args.Length);
                    foreach (String arg in args)
                    {
                        Console.WriteLine(arg);
                    }
                    Console.WriteLine("");
                    
                    Console.WriteLine("size of {0} = {1}", fileName, stream.Length);
                    
                    char[] contents = new char[stream.Length];

                    // file to array reading
                    for (int i = 0; i < stream.Length; i++)
                    {
                        contents[i] = (char)reader.Read();
                    }

                    // write array of characters
                    foreach (char c in contents) { Console.Write(c); }

                    // close file
                    reader.Close();
                    stream.Close();

                    // file analyze
                    Summ(contents);
                }
                else
                {
                    Console.WriteLine("Usage: FileDetail.exe file.txt");
                }
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
