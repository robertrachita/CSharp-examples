using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton2022
{
    public static class FileWriter
    {
        public static async Task WriteArray(string fileName, string[] content)
        {
            await File.WriteAllLinesAsync(fileName, content);
        }

        public static async Task WriteLine(string fileName, string content)
        {
            await File.WriteAllTextAsync(fileName, content);
        }

        public static async Task NewAppend(string fileName, string content)
        {
            await File.AppendAllTextAsync(fileName, content);
        }

        public static async Task AppendArray(string fileName, string[] content)
        {
            foreach (string line in content)
            {
                await File.AppendAllTextAsync(fileName, line);
            }
        }

        public static async Task WriteNewLine(string fileName)
        {
            using StreamWriter file = new(fileName, append: true);
            await file.WriteLineAsync("\n");
        }
        
        public static async Task Append(string fileName, string content)
        {
            using StreamWriter file = new(fileName, append: true);
            await file.WriteLineAsync(content);
        }

        public static async Task Append(string fileName, string[] content)
        {
            using StreamWriter file = new(fileName, append: true);
            foreach(string line in content)
            {
                await file.WriteLineAsync(line);
            }
        }

    }
}
