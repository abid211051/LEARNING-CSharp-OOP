using ObjectOriented;
using System;

namespace Oop
{
    class Program
    {
        static void Main()
        {
            // By using class we can create reuseable chunk of code
            // Class gives more security on an our data
            // By using class we can get some advance terms
            // 1. Inheritance
            // 2. Polymorphism
            // 3. Encapsulation
            // 4. Abstraction

            Console.WriteLine("//** CREATING CLASS AND CLASS OBJECT IN OOP C# **//");
            // Creating a object of Human class
            Human human1 = new Human();
            human1.HumanInfo();
            human1.name = "afnan";
            human1.age = 23;
            human1.HumanInfo();


            Console.WriteLine("\n//** CONSTRUCTOR IN OOP C# **//");
            // Creating object of Car with Constructor value
            Cars car1 = new Cars("Tesla", 1000, "red");
            car1.CarInfo();
            Cars car2 = new Cars();
            Cars car3 = new Cars("Tata", "blue");
            car3.CarInfo();


            Console.WriteLine("\n//** GET AND SET METHOD IN OOP C# **//");
            // Getter and Setter methods
            Area area1 = new Area();
            area1.SetValue(5, 10);
            Console.WriteLine($"Total area for area1 is : {area1.GetValue()}");
            // Get and Set property
            Area area2 = new Area();
            area2.SetWidth = 30;
            area2.SetHeight = 10;
            Console.WriteLine($"Total area for area2 is : {area2.GetTotal}");


            Console.WriteLine("\n//** INHERITANCE IN OOP C# **//");
            //Inheritance with Constructor

            //This is derived class which have Parent class field and property
            //However It is not sending any parameter to constructor, so Parent class
            // parameterless and child class parameterless constructor will execute as we
            // set an parameterless constructor in Child class also
            Child inherite1 = new Child();

            //This derived class is calling Parent parameterd constructor by base()
            // and Child constructor. Note: Here we are sending one Child constructor value also
            Child inherite = new Child("kaji", "islam", "male");

            //This is Child own constructor. Though we set two parameter here
            //but this constructor will skip Inherited Parent constructor, as we are passing
            //different datatype value here.Which is not matching Inherited constructor
            //parameter sequence.
            Child inherite2 = new Child(19, "abid");
            inherite2.ChileInfo();


            Console.WriteLine("\n//** POLYMORPHISM **//");
            //Polymorphism
            Animal myAnimal = new Animal(); 
            Animal myPig = new Pig(); 

            myAnimal.animalSound();
            myPig.animalSound();

        }
    }
}