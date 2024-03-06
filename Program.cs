// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Animals {
    class Program {
        private const int V = 4;

        static void Main(string[] args) {
            Console.WriteLine("Hello, World!"); 
            doSomething();      
        }

        static void doSomething() {
            Animal lapDog = new Animal(
                userSpecies: "dog.mutt",   
                userName: "fido",
                userFeet: 4,
                userIsVertebrate: true
             
            );
            lapDog.PrintProperties();

            Animal shizi = new Animal(
                "dog.shizi",
                "sam the sham",
                4,
                true
            );
            shizi.PrintProperties();

            Animal snakey = new Animal(
                "reptile.snake",
                "snakey",
                userIsVertebrate: true
            );
            snakey.PrintProperties();

            Horse neigh = new Horse(
                uColor: "brown", true, 12.5, "neigh"
            );
            neigh.horseProperties();
        }
    }
}

