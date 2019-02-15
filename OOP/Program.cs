using System;

namespace OOP
    //Class-
    //A class is like a blueprint or model, for creating a object. (specifies what the type can do)
    //Used as a definition, to create objects.
    //A class is a data structure, that may contain: data members(constants and fields), function members (methods,
    //properties, events, indexers, operators, instance constructors, destructors, and static constructors), and nested types.

    //Defining a class we need 4 things:
    //1. Accessor- control accessibility of the class (by default are set to internal)
    //2. Class keyword- says code is a class
    //3. Name of class- used to create object instances (what you are modeling)
    //4. Code block- contains all data and function memebers the class has access to

    //A class is a reference type
    //--------------------------------------------------------------------------------------------------------

    //A object is basically a block of memory that has been allocated and configured according to the blueprint
    //Objects are also called instances, and they can be stored in either a named variable or in an array or collection
    //Because classes are reference types, a variable of a class object holds a reference to the address of the object on the managed heap

    //Instantiating an object- definition to create (instantiate) object instances.
    //Each object is its own instance (created by the 'new' operator)
{
    class Program
    {
        //Method-
        //A method is a code block that contains a series of statements
        //Named blocks of code that perform task (the "verbs")
        //Methods are declared in a class or struct
        //Executed by calling the method and specifying any required method arguments
        //In C#, every executed instruction is performed in the context of a method

        //Must be a member of a class
        //The method signature must be unique
        //First letter of it name must be a letter or a underscore (proper casing- capitalize first letter)

        //Allows for code reusability
        //Organize complex problems - into small steps
        //Better code readability (meaningful names)

        //Creating a method we need 5 things:
        //1. Access level- who call the method
        //2. Return type- does it return data? if so what type
        //3. Name- alias, other pieces code call this
        //4. Parameters- data that is passed into a method to do its job
        //5. Code block- statements that run when method is called
        //1-4 make up the method signature

        //The Main method is the entry point for every C# application (called by CLR when program starts)

        static void Main(string[] args)
        {
            Example Ps = new Example();
            Ps.PrintSomething();
            //Instantiating the class 'Example' - declaring the variable type
            //name of new variable 'Ps'
            //creating a new object "instance", and assiging variable to it


            Console.WriteLine("Press 'Enter' to start stopwatch");
            Console.ReadKey();

            StopWatch sw = new StopWatch();
            sw.StartTime();

            Console.WriteLine("Press 'Enter' to stop stopwatch");
            Console.ReadKey();
            sw.StopTime();


            Calculator Cal = new Calculator();

            Console.WriteLine(Cal.Add(1, 2));

            Console.WriteLine(Cal.Sub(1, 2));

            Console.WriteLine(Cal.Muly(1, 2));

            Console.WriteLine(Cal.Div(1, 2));

            Console.WriteLine(Cal.FindMax(1, 2, 3));

            Console.WriteLine("Enter a number to be squared");
            string snumber = Console.ReadLine();
            int number = int.Parse(snumber);
            Console.WriteLine(Cal.Square(number));


        }

    }
}
//The 3 pillars of object oriented programming (oop)
//1. Encapsulation - How does the the language hide the internal implementation details,
//and preserve data integrity?
//2. Inheritance - How does the language promote code reuse?
//3. Polymorphism - How does the language let you treat related objects in a similar way?

//In oop everything is an object
//Every object can have its own properties (data), and methods (functions)
//Objects can have it own objects (the car has an engine with its own properties)
//All objects are defined by classes
//Classes are the blueprints that define what an object can do, what it can store, and how it functions
//When we create a new object base on a class it contains all the nonprivate members of that class
//Objects give us an opportunity to expose functionality and hide it implementation (abstraction)




//Field- variable that belongs to your class
//Fields are members of their containing type
//Can be of any type, even user defined (like classes)
//Has scope in the entire class (so any method in the class can see it)
//Used to store information within the class (most often private, to keep control of manipulation)
//Should use camelCase

//Properties- represent items of data in a class or instance
//A flexible mechanism to read, write, or compute the value of a private field
//Just like a field (have a name and type), but they can assigned to and read from (get, set accessor methods)
//Properites are actually methods, just look like fields
//Get returns the value of the private "backing" field
//Set assigns the private "backing" field to the value passed in
//The value keyword in set is a contextual keyword
//Reasons to use a backing field (control access to data, or do a calculated field "read only variables")
//You can omit the "backing field", by using an auto property
//Should use PascalCase


//Constructors- When a class or struct is created, its constructor is called. 
//Constructors have the same name as the class or struct, and they usually initialize the data members of the new object
//A special kind of method
//Ensuring valid data is passed to create (instantiate) a object
//Every class has a default constructor
//A constructor that takes no parameters is called a default constructor
//You can have multiple constructors with a different set of parameters and the different number of parameters (Constructor Overloading)
//Use constructor overloading for custom logic


//Contextual keyword- keywords are predefined, reserved identifiers that have special meanings to the compiler

//scope- declaration space of an identifier for a variable, reference or method "where can this thing be used"

//Parameter- is a variable in a method definition
//Argument- is the actual value of this variable that gets passed to function


//heap acts as a pool of storage area that allocated the memory randomly (Dynamic memory allocation)
//the managed heap is the one that .net will manage for you, that all standard objects are created on, 
//that you normally don't need to bother too much about because it is managed.
//unmanaged heap means that you are personally allocating memory, and so you are personally responsible for deallocating it, 
//managing it yourself, and keeping track of what is being used.