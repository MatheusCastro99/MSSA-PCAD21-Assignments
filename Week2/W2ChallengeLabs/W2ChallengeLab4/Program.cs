using W2ChallengeLab4;

Student John = new(01, "John Cena");
John.AddGrade("Physics", 70);
John.AddGrade("Chemistry", 80);
John.AddGrade("Computer Application", 90);

Student Mary = new(02, "Just Mary");
Mary.AddGrade("Math", 95);
Mary.AddGrade("Chemistry", 40);
Mary.AddGrade("Poetry", 60);
Mary.AddGrade("Biology", 75);

Console.WriteLine("Press any key to continue:");
Console.ReadKey();
Console.Clear();

John.DisplayGrades();
Mary.DisplayGrades();

Console.ReadLine();