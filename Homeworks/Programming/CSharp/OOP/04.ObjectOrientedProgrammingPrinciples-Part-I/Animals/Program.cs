//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, 
//frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
//Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only 
//female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of
//animal using a static method (you may use LINQ).



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main()
        {
            Tomcat tom = new Tomcat("Tom", 12);
            Console.WriteLine(tom);
            Kitten kitty = new Kitten("Kitty", 3);
            Console.WriteLine(kitty);
            Console.WriteLine();

            List<ISound> listAnimals = new List<ISound>();
            listAnimals.Add(new Cat("Pepi", 3, "female"));
            listAnimals.Add(new Frog("Kurmit", 10, "male"));
            listAnimals.Add(new Dog("Sharo", 5, "male"));
            listAnimals.Add(new Cat("Jorko", 6, "male"));
            listAnimals.Add(new Dog("Balkan", 10, "male"));
            listAnimals.Add(kitty);
            listAnimals.Add(tom);
            foreach (var animal in listAnimals)
            {
                Console.WriteLine(animal + " " + animal.MakeSound());
            }

            Console.WriteLine();

            Animal[] animals = new Animal[]
            {
                new Cat("Pepi", 3, "female"),
                new Frog("Kurmit", 10, "male"),
                new Dog("Sharo", 5, "male"),
                new Cat("Jorko", 6, "male"),
                new Cat("Tom",12,"male")
            };

           
           Console.WriteLine(Animal.GetAvaregeAge(animals));

           var ages =
               (from animal in animals
                where animal.GetType() == typeof(Cat)
                select animal.age).Average();
           Console.WriteLine(ages);
        }
    }
}
