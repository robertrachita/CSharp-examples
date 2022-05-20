using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton2022
{
    public static class File
    {
        static File()
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

        public static void WriteFile(string fileName, string content)
        {
            System.IO.File.WriteAllText(fileName, content);
        }

        public static void WriteFileLines(string fileName, string[] content)
        {
            System.IO.File.WriteAllLines(fileName, content);
        }

        public static void AppendFile(string fileName, string content)
        {
            System.IO.File.AppendAllText(fileName, content);
        }

        public static void AppendFileLines(string fileName, string[] content)
        {
            System.IO.File.AppendAllLines(fileName, content);
        }

        public static void DeleteFile(string fileName)
        {
            System.IO.File.Delete(fileName);
        }

        public static bool FileExists(string fileName)
        {
            return System.IO.File.Exists(fileName);
        }

        public static void CreateDirectory(string directoryName)
        {
            System.IO.Directory.CreateDirectory(directoryName);
        }

    }

}
