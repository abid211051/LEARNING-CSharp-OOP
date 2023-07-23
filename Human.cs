using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    class Human
    {
        // 1. Here public means this public member is accessible from any class
        // This public, private are called access modifier
        // -> "public" The code is accessible for all classes
        // -> "private" The code is only accessible within the same class
        // -> "protected" The code is accessible within the same class, or in a class that is inherited from that class.
        // -> "internal" The code is only accessible within its own assembly, but not from another assembly.
        // 2. By default all function and variable keep as private
        // 3. Initialized variable will work as default value, whenever
        // a object created on that class. If we set value on class
        // Object it will replace the default value
        public string name = "abid";
        public int age = 19;
        public string nation = "BD";
        public void HumanInfo()
        {
            Console.WriteLine($"Human name :{name} Human age: {age}");
        }
    }

    // Constructor Example with multiple constructor
    class Cars
    {
        private string name;
        private int power;
        private string color;

        // 1. This is a Cars Class constructor. Which will call whenever 
        // a object created on that class. Note: Constructor call before all
        // attributes or members
        // 2. Constructor can get  parameter whenever a object created on that class
        // 3. By giving parameter in constructor whenever a object created, we can
        // keep our class member more secure. Here member variable are
        // set as private, still wee can set value on those variable from another class

        // This Constructor will work as default constructor, if no parameter sended
        public Cars()
        {
            Console.WriteLine("This is a Default constructor");
        }
        public Cars(string name, string color)
        {
            // "this" will point to the class members which name was set as "color"
            this.name = name;
            this.color = color;
        }
        public Cars(string _name, int _power, string color)
        {
            name = _name;
            power = _power;
            this.color = color;
        }

        // Here by using if-else we are managing output of CarsInfo.
        // Beacuse if we don't give value for all the class member variable
        // default value will set on those missing value variable without showing error. It can be null or 0
        public void CarInfo() 
        {
            if(power != 0)
            {
                Console.WriteLine($"Car name: {name}. Car power : {power}Hz. Car color : {color}");
            }
            else
            {
                Console.WriteLine($"Car name: {name}. Car color : {color}");
            }
        }
    }

    //Get and Set data (Encapsulation)
    // 1. Here we are not giving our data from variable directly to other classes
    // We use SetValue and GetValue method to set and get data from those member
    // variable. This is called data Encapsulation.
    class Area
    {
        private int width2;
        private int height2;
        public int SetWidth
        {
            set { width2 = value; }
        }
        public int SetHeight
        {
            set { height2 = value; }
        }
        public int GetTotal
        {
            get { return width2 * height2; }
        }

        // Alternative way
        private int width;
        private int height;
        public void SetValue(int _width, int _height)
        {
            if(_width <= 0 || _height <= 0)
            {
                throw new Exception("Width and Height must be greater then 0");
            }
            width = _width;
            height = _height;
        }
        public int GetValue()
        {
            return this.width * this.height;
        }
    }

    //Inheritance
    // 1. Inheritance is used to inherite parent class fields and methods
    // to child class. It is used to get some common field and method
    // without creating them again in another class
    class Parent
    {
        public Parent() 
        {
            Console.WriteLine("This is Parent parameterless constructor");
        }
        protected string familyName;
        protected string religion;

        public Parent(string _familyName, string _religion)
        {
            this.familyName = _familyName;
            this.religion = _religion;
        }
    }
    class Child : Parent
    {
        private string name;
        private int age;
        private string gender;
        //This Child constructor will Call Parent parameterless
        // constructor and his constructor also,
        public Child()
        {
            Console.WriteLine("This is Child parameterless constructor");

        }
        // if there is a parametered constructor in parent class then
        // we have to inherit that constructor with base() method like below
        public Child (string _familyName, string _religion, string gender) : base(_familyName, _religion)
        {
            this.gender = gender;
            Console.WriteLine("This is Parent class field FamilyName :" + _familyName);
            Console.WriteLine("This is Parent class field Religion :" + _religion);
            Console.WriteLine("This is Chiild class field Gender :" + this.gender);
        }
        public Child(int _age,  string _name)
        {
            this.name = _name;
            this.age = _age;
        }
        public void ChileInfo()
        {
            Console.WriteLine($"Child Own name : {name}; Age: {age}");
        }
    }

    //Polymorpism
    //1. By inheritance we inherited Parent class to child class, and
    // got field, methods, properties. But now if we want to modify Parent method
    // We use polymorpism,Here we use : 1. Virtual in Parent class methods
    // and 2. override in Child class methods

    class Animal
    {
        //Virtul before base class method
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig : Animal 
    {
        //override before derived class method, to override parent method
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
} 
