using System;
using System.Collections.Generic;
using System.Text;

namespace W2ChallengeLabExtra
{
    public class Allergies
    {
        // do not alter this enum
        [Flags]
        public enum Allergen
        {
            Eggs = 1,
            Peanuts = 2,
            Shellfish = 4,
            Strawberries = 8,
            Tomatoes = 16,
            Chocolate = 32,
            Pollen = 64,
            Cats = 128
        }

        // write your code below this line

        // constructors ====================================================================

        public Allergies(string name, int score) 
        {
            Name = name;
            Score = score;

            DetermineAllergiesFromScore();
        }

        public Allergies(string name)
        {
            Name = name;
            Score = 0;
            
            Console.WriteLine($"{Name} has no Allergies!");
        }

        public Allergies(string name, string allergiesToParse)
        {
            Name = name;
            string[] allergiesArray = allergiesToParse.Split(new char[] { ' ' });

            foreach (string s in allergiesArray)
            {
                PersonAllergies.Add(s);
            }

            DetermineScoreFromAllergies();
        }

        // properties =========================================================================

        private string Name { get; set; }
        private int Score { get; set; }
        private List<string> PersonAllergies { get; set; } = new List<string>();

        // methods ==========================================================================
   
        private void DetermineAllergiesFromScore()
        {
            int tempScore = Score;
            foreach (var i in Enum.GetValues<Allergen>().Reverse<Allergen>())
            {
                if(tempScore - i < 0)
                {
                    continue;
                }

                tempScore -= Convert.ToInt32(i);
                PersonAllergies.Add(i.ToString());
            }

            //Console.WriteLine(string.Join(", ", PersonAllergies));
        }

        private void DetermineScoreFromAllergies() 
        {
            foreach (string s in PersonAllergies)
            {
                Enum.TryParse(s, out Allergen allergyScore);
                Score += Convert.ToInt32(allergyScore);
            }

            //Console.WriteLine($"Score: {Score}");
        }

        public bool IsAllergicTo(string allergen)
        {
            if (PersonAllergies.Contains(allergen))
            {
                Console.WriteLine($"{Name} is allergic to {allergen}");
                Console.WriteLine();
                return true;
            }
            else 
            {
                Console.WriteLine($"{Name} is not allergic to {allergen}");
                Console.WriteLine();
                return false;
            }
        }

        public bool IsAllergicTo(Allergen allergen)
        {
            if (PersonAllergies.Contains(allergen.ToString())) 
            {
                Console.WriteLine($"{Name} is allergic to {allergen.ToString()}");
                Console.WriteLine();
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} is not allergic to {allergen.ToString()}");
                Console.WriteLine();
                return false;
            }
        }

        public void AddAllergy(string newAllergy) 
        {
            if (PersonAllergies.Contains(newAllergy))
            {
                Console.WriteLine("Allergy already listed");
                Console.WriteLine();
            }
            else if (Enum.TryParse<Allergen>(newAllergy, out Allergen allergy))
            {
                Score += Convert.ToInt32(allergy);
                PersonAllergies.Add(newAllergy);

                Console.WriteLine($"{newAllergy} added to {Name} alergy list, new score is: {Score}");
                Console.WriteLine();
            }
        }

        public void DeleteAllergy(string outAllergy)
        {
            if (PersonAllergies.Contains(outAllergy))
            {
                Enum.TryParse<Allergen>(outAllergy, out Allergen allergy);

                Score -= Convert.ToInt32(allergy);
                PersonAllergies.Remove(outAllergy);

                Console.WriteLine($"{outAllergy} removed from {Name} allergy list, new score is: {Score}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{outAllergy} not in the allergy list for {Name}");
                Console.WriteLine();
            }
        }
        public override string? ToString()
        {
            string response = "";
            // add code here to return string representation of this instance
            if (Score == 0)
            {
                response = $"{Name} has no Allergies!";
            }
            else
            {
                response = $"{(string)Name} is allergic to: {string.Join(", ", PersonAllergies)}\nWith a allergen score of {Score}";
            }
            
            Console.WriteLine($"{response}");
            Console.WriteLine();
            return response;
        }
    }
}
