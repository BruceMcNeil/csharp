
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Animals {

    public class Animal {
        public string? species { get; set; }
        public string? name { get; set; }
        public int numberOfFeet { get; set; }
        public bool isVertebrate { get; set; }

        public Animal(
            string userSpecies = "undefined", 
            string userName = "undefined", 
            int userFeet = 0, 
            bool userIsVertebrate = false)
        {
            species = userSpecies;
            name = userName;
            numberOfFeet = userFeet;
            isVertebrate = userIsVertebrate;
        }

        public void PrintProperties()
        {
            Console.WriteLine("Species: {0} is {1} big {2}", species, "foobar", species + " deal");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Number of feet: {0}", numberOfFeet);
            Console.WriteLine("Is vertebrate: {0}", isVertebrate);
            Console.WriteLine(); // Add an empty line for better readability
        }

    }

    class Horse : Animal {
        string? color {get; set;}
        bool isMale {get; set;}
        double age {get; set;}

        public Horse(
            string uColor = "undefined",
            bool male = false,
            double uAge = 0.0,
            string uName = "olYaller"
        ) : base(
            userSpecies: "horse", 
            userName: uName, 
            userFeet: 4,
            userIsVertebrate: true)
        {
            color = uColor;
            isMale = male;
            age = uAge;
        }

        public void horseProperties()
        {
            base.PrintProperties();
            Console.WriteLine("color: {0} is {1} big {2}", color, "foobar", species + " deal");
            Console.WriteLine("male: {0}", isMale);
            Console.WriteLine("age: {0}", age);
            Console.WriteLine(); // Add an empty line for better readability
        }        

    }

}