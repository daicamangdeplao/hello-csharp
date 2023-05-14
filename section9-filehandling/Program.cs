using System.Text;

namespace section9_filehandling;

internal static class Program
{
    private const string path = @"C:\workspace\projects\hello-csharp\section9-filehandling\resource\friends.txt";
    public static void Main(string[] args)
    {
        // Read file line by line
        var content = ReadFile();
        var originalContent = content;
        Console.WriteLine(content);
        // Append a new line into a file
        WriteFile("foe");
        content = ReadFile();
        Console.WriteLine(content);
        // Restore file to previous state
        RestoreFile(originalContent);
    }

    private static void RestoreFile(string originalContent)
    {
        File.WriteAllText(path, originalContent);
    }

    private static void WriteFile(string contentOfSingleLine)
    {
        using StreamWriter sw = File.AppendText(path);
        sw.WriteLine(contentOfSingleLine);
    }

    private static string ReadFile()
    {
        StringBuilder content = new StringBuilder();
        try
        {
            StreamReader sr = new StreamReader(path);
            var line = sr.ReadLine();
            
            while (line != null)
            {
                content.Append(line);
                content.Append('\n');
                line = sr.ReadLine();
            }
            sr.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Executing the finally block.");
        }

        return content.ToString();
    }
}