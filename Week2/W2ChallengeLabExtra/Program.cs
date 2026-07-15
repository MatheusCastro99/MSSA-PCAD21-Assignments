using W2ChallengeLabExtra;

Console.WriteLine("Hello, World!");

Allergies john = new("John", 125);
Allergies Mary = new("Mary", "Peanuts Shellfish Tomatoes Cats");

john.ToString();
john.IsAllergicTo("Eggs");
john.AddAllergy("Cats");

Mary.ToString();
Mary.IsAllergicTo(Allergies.Allergen.Pollen);
Mary.DeleteAllergy("Cats");