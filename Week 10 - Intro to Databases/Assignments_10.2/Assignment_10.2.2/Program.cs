//Write a program to create a list of employees. Consider a hard coded list.
//Display all employees who have salary more than $5000 and age < 30.

using Assignment_10._2._2;

List<Employees> listOfEmployees = new();

listOfEmployees.Add(new Employees("John", 10000, 25));
listOfEmployees.Add(new Employees("Jane", 4000, 45));
listOfEmployees.Add(new Employees("Joseph", 5000, 30));
listOfEmployees.Add(new Employees("Johanna", 7000, 29));

List<Employees> selectedEmployees = listOfEmployees
    .Where(employee => 
        employee.Salary > 5000 && 
        employee.Age < 30)
    .ToList();

Console.WriteLine(string.Join("\n--------\n", selectedEmployees));


