using System.IO;
using System.Collections.Generic;

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach(var file in foundFiles){
        // if(file.EndsWith("sales.json")){
        //     salesFiles.Add(file);
        // }
        var extension = Path.GetExtension(file);
        if(extension == ".json"){
            salesFiles.Add(file);
        }
    }
    return salesFiles;
}

// var salesFiles = FindFiles("stores");

// foreach(var file in salesFiles){
//     Console.WriteLine(file);
// }

// Console.WriteLine(Directory.GetCurrentDirectory());

// string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
// Console.WriteLine(docPath);

// Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");

// Console.WriteLine(Path.Combine("stores","201"));

// Console.WriteLine(Path.GetExtension("sales.json"));

// string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

// FileInfo info = new FileInfo(fileName);

// Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}");

var currentDirectory = Directory.GetCurrentDirectory();

var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesFiles = FindFiles(storesDirectory);

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");

// foreach(var file in salesFiles){
//     Console.WriteLine(file);
// }

Directory.CreateDirectory(salesTotalDir);

File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), String.Empty);


