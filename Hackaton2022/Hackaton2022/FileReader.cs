using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton2022
{
    public static class FileReader
    {
        static FileReader()
        {
        }

        public static string ReadFile(string fileName)
        {
            return System.IO.File.ReadAllText(fileName);
        }

        public static string[] ReadFileLines(string fileName)
        {
            return System.IO.File.ReadAllLines(fileName);
        }


        public static bool FileExists(string fileName)
        {
            return System.IO.File.Exists(fileName);
        }

        public static void CreateDirectory(string directoryName)
        {
            System.IO.Directory.CreateDirectory(directoryName);
        }

        public static void WriteToConsole(string[] lines)
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public static void WriteToConsole(string lines)
        {

            Console.WriteLine(lines);
        }

        public static void WriteNewLineToConsole()
        {
            Console.WriteLine();
        }

    }

}
