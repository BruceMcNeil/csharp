using System;
namespace Animals; 

class Tortoise{
    public bool isMale {get; set;}
    public string? species {get; set;}
    public int age {get; set;}

    public string? shellType {get; set;}

    public Tortoise (int Age, bool Male, string Species = "undefined", string Shell = "Not Known"){
        isMale = Male;
        age = Age;
        species = Species;
        shellType = Shell;
    }

    public void PrintProperties() {
        Console.WriteLine("Gender is {0}", isMale);
        Console.WriteLine("Age is {0}", age);
        Console.WriteLine("Species is {0}", species);
        Console.WriteLine("Shell structure is {0}", shellType);
    }
}
