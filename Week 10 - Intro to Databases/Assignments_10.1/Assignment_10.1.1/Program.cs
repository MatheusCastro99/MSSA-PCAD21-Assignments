//Create any user defined class of your choice like Student, Customer etc. Add 3 properties in it (of your choice).
//Serialize and deserialize the object of this class by Binary, XML, JSON format.

using Assignment_10._1._1;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

Student JohnDoe = new()
{
    Id = 1,
    Name = "Cleiton",
    Age = 10,
    Major = "Engrish"
};

//JSON--------------------------------------------------------------------------------
Console.WriteLine("JSON--------------------------------------------------------\n");

Console.WriteLine("Serialized:");
var jsonBody = JsonSerializer.Serialize(JohnDoe);
Console.WriteLine(jsonBody);

Console.WriteLine("\nDeserialized:");
Student? jsonResponse =  JsonSerializer.Deserialize<Student>(jsonBody);
Console.WriteLine(jsonResponse?.ToString());

Console.WriteLine();

//XML---------------------------------------------------------------------------------
Console.WriteLine("XML--------------------------------------------------------\n");

Console.WriteLine("Serialized:");
string filePath = "student.xml";
string xmlBody = "";

XmlSerializer serializer = new XmlSerializer(typeof(Student));
using (StringWriter sw = new StringWriter())
{
    serializer.Serialize(sw, JohnDoe);

    xmlBody = sw.ToString();
    Console.WriteLine(xmlBody);
}

Console.WriteLine("\nDeserialized:");
using (StreamReader reader = new StreamReader(filePath))
{
    Student? xmlDeserialized = (Student?)serializer.Deserialize(reader);

    Console.WriteLine(xmlDeserialized?.ToString());
}

Console.WriteLine();

//Binary------------------------------------------------------------------------------

//.NET BinaryFormatter was discontinued due to severe security vulnerabilities
//External Packages like MessagePack or protobuf-net can be utilized to achieve this