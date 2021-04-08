using System.IO;
using System;
public class FileIO
{
    public void LearnFileHandling()
    {
        var x = @"E:\Dotnet\Kushal-Kattel\README.md";
        string y = "Generic.cs";
        if (File.Exists(x))
        {
            var fileContent = File.ReadAllLines(x);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(fileContent);
        }
    }
    public void LearnFileWriting()
    {
        string x = "ABC.txt";
        File.WriteAllText(x, "Creating a fil and writing content");
    }

    public void LearnFileInfo()
    {
        string filePath = "ABC.txt";
        FileInfo fileInfo = new FileInfo(filePath);
        var size = fileInfo.Length;
        var createdDate = fileInfo.CreationTime;

        Console.WriteLine($"size is {size} and created date is {createdDate}");
    }
    public void LearnDirectory()
    {
        string folderPath = "Kushal-Kattel";
        Directory.CreateDirectory(folderPath);
        string conform = Console.ReadLine();
        if (conform == "Y")
        {
            Directory.Delete(folderPath);
        }
    }

    public void HomeWork()
    {
        string name = "name";
        string foldername = "Nepal";
        Directory.CreateDirectory(foldername);
        for (int i = 0; i < 10; i++)
        {
            string subFolder = Path.Combine(foldername, name);
            Directory.CreateDirectory(subFolder);
            File.WriteAllText(Path.Combine(subFolder, "Text.txt"), name);
        }

    }

    //Create a folder "Nepal" in Nepal create new 10 sub folders.
    //Every subfolder should contain a file Text.txt with subfolder name as a content.
}