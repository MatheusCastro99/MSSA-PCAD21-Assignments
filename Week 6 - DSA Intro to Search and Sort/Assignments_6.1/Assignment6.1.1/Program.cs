//Implement a single linked list with each node representing a house. You may add data in it like house number, brief address, type of house (like Ranch, Colonial).
//each house (node) will be linked to next. Give facility to the user to search a house by its number and then display the details. (Windows / Console)

using Assignment6._1._1;
MyLinkedList HouseList = new MyLinkedList();

GenMockData();

HouseList.PrintList();

Console.WriteLine("Type exit at anything to exit application");

while (true)
{
    Console.WriteLine("Type to search house: ");
    string searchData = Console.ReadLine();

    if( searchData == "exit") 
    {
        Console.WriteLine("Thank you for using this app");
        return;
    }

    if (searchData == null || searchData == "")
    {
        Console.WriteLine("Please type some data to filter the list");
        continue;
    }

    else
    {
        HouseList.SearchHouse(searchData);
    }
}

void GenMockData()
{
    HouseList.AddToEnd(new("1223", "this street", "single-family"));
    HouseList.AddToEnd(new("1350", "other street", "apartment"));
    HouseList.AddToBeginning(new("2015", "another street", "Tiny house"));
    HouseList.AddToEnd(new("5423", "street street", "single-family"));
    HouseList.AddToEnd(new("9806", "other street", "apartment"));
    HouseList.AddToBeginning(new("2015", "not same street", "Tiny house"));
}