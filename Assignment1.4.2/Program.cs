Console.WriteLine("Hello, World!");
Console.WriteLine();

Student John = new Student(1, "John", "Doe", new DateTime(1096, 1, 1), 'A');
Student Jane = new Student(2, "Jane", "Smith", new DateTime(2001, 2, 2), 'B');

Console.WriteLine($"Student ID: {(John.ID)}, Name: {John.FirstName} {John.LastName}, Grade: {John.Grade}");
Console.WriteLine($"Student ID: {(Jane.ID)}, Name: {Jane.FirstName} {Jane.LastName}, Grade: {Jane.Grade}");
Console.WriteLine();

John.Grade = 'C';
Jane.LastName = "Doe";

John.DisplayStudentInfo();
Jane.DisplayStudentInfo();

Console.WriteLine("\nPause here to demonstrate exeption on invalid date of birth. Press any key to set the date of birth for John to 2050");
Console.ReadLine();

John.DateOfBirth = new DateTime(2050, 1, 1); // This will throw an exception because the date is in the future.


class Student
{
    //redo class and choose better variable names, do not use private variables, use properties instead.
    //attempt to add a DateTime property for the date of birth and a char property for the grade.
    //Add a method to display the student information.

    public string ID { get; set; }
    public char Grade { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth 
    {
        get;
        set
        {
            DateTime DOBHolder;
            if (DateTime.TryParse(value.ToString(), out DOBHolder))
            {
                if (DOBHolder > DateTime.Now)
                {
                    throw new ArgumentException("Date of birth cannot be in the future.");
                }
                else
                {
                    DOBHolder = value;
                    field = DOBHolder;
                }
            }
            else
            {
                throw new ArgumentException("Invalid date format.");
            }
        }
    }

    public Student(int id, string firstName, string lastName, DateTime dateOfBirth, char grade)
    {
        ID = id.ToString();
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Grade = grade;
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Student ID: {ID}, Name: {FirstName} {LastName}, Date of Birth: {DateOfBirth.ToString("d")}, Grade: {Grade}");
    }
}