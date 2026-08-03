using System.IO;

/*

string filePath = "example.txt";
File.WriteAllText(filePath, "Hello, World!"); // Write text to the file, overwrites the file if it already exists, not memory efficient for large files

string content = File.ReadAllText(filePath);
Console.WriteLine(content);
Console.WriteLine(Path.GetFullPath(filePath));

//====================================================================================================================================================================

string anotherPath = "second_example.txt";
StreamWriter writer = new StreamWriter(anotherPath, append: false); // Create a StreamWriter to write to the file, appending if it already exists
writer.WriteLine("This is a new line of text.");
writer.Close();  //Manually close the StreamWriter to ensure all data is flushed to the file

StreamReader reader = new StreamReader(anotherPath);
string line;
while ((line = reader.ReadLine()) != null) // Read the file line by line
{
    Console.WriteLine(line);
}
reader.Close(); // Manually close the StreamReader to free resources

*/

//====================================================================================================================================================================

string filePath = "user_info.txt";
using (StreamWriter writer = new StreamWriter(filePath, append: false)) // Append: false means overwrite the file if it exists. Use true to append to the file instead of overwriting it.
{
    writer.WriteLine("User: John Doe");
    writer.WriteLine("Email: john.doe@example.com");
    writer.WriteLine("Age: 30");
    writer.WriteLine("Address: Manhattan, NY");
}

using (StreamReader reader = new(filePath)) //new() calls the constructor of StreamReader with the specified file path
{
    string userLine;
    while ((userLine = reader.ReadLine()) != null)
    {
        Console.WriteLine(userLine);
    }
}