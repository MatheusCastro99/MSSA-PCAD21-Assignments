//Explore Linkedlist class from C# library.

using Assignment6._1._2;

LinkedList<House> HouseList = new();
GenMockData();

//HouseList.Find(); //Built-in find will expect a House Node as argument, meaning I could only pass an instace of House and not the actual property

Console.WriteLine("Enter to search house: ");
string target = Console.ReadLine();
FindHouse(target);

void FindHouse(string target)
{
    House searchHouse = HouseList.FirstOrDefault(house => house.HouseNumber == target); //Will return only the first node whose property matches input

    if (searchHouse != null)
    {
        Console.WriteLine($"Found house: {searchHouse.ToString()}");
    }
}

void GenMockData()
{
    HouseList.AddLast(new House("1223", "this street", "single-family"));
    HouseList.AddLast(new House("1350", "other street", "apartment"));
    HouseList.AddFirst(new House("2015", "another street", "Tiny house"));
    HouseList.AddLast(new House("5423", "street street", "single-family"));
    HouseList.AddLast(new House("9806", "other street", "apartment"));
    HouseList.AddFirst(new House("2015", "not same street", "Tiny house"));

    foreach (House house in HouseList)
    {
        Console.WriteLine(house.ToString() + "\n");
    }
}