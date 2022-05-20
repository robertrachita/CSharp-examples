using Hackaton2022;


string path = "@..\\..\\..\\..\\..\\test.txt";
String[] strings = FileReader.ReadFileLines(path);

//FileReader.WriteToConsole(strings);

FileWriter.WriteNewLine(path);
FileWriter.Append(path, "yes");

FileReader.WriteToConsole(FileReader.ReadFile(path));


Console.WriteLine("Press any key to exit.");
System.Console.ReadKey();