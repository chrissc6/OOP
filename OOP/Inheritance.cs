using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Inheritance
    {
    }
}
//Inheritance- build class definitions based on existing definitions ("extending" a base class)
//Establishes an "is-a" relationship between types (a rectangle is-a shape that is-an object)
//In .Net every class starts with System.Object,
//thats why "every class" all types have a "ToString()" method available

//Share the code (reuse code)
//Often have many classes that contain functionality that is related,
//inheritance allows us to share code that is common and optionally extend or override that code for specific needs
//Very much tied into polymorphism

//Extending classes via inheritance
//You use an existing class (base class) as the basis for a new class (derived class)
//A derived class can access its own members, and also non private members of the base class
//A derived class gets access to all public and protected members of the base class
//Declaring a derived class requires a colon followed by the type of the base class (just like implementing an interface)
//A derived class extends the base class (adds additional functionality)
//A derived class cannot delete any of the members it has inherited
//You can access members of the base class the same way you access other members

//Virtual and Override
//optional keywords unless declared it will behave like a normal method
//used with inheritance for extending behavior
//By declaring a method virtual you can allow derived classes to override it and provide their own implementation
//You can have many overrides down the inheritance chain, the highest override will win
//You can call up the chain using the "base" keyword

//Abstract members
//Function members marked with the "abstract" keyword
//Dont have an implementation, the signature end with a semicolon
//Any class that is derived must implement the abstract member
//Can only exist in abstract classes
//You cannot instantiate an abstract class directly (because there is no implementation code), only the derived classes

//Sealed classes
//A sealed class cannot be inherited from
//Usually done with api coding (so others dont tamper with their classes)

//Inheritance vs Interfaces
//A class can only inherit from one class, but it can implement as many interfaces as it want, separated by commas
//Inherited classes can share their members with the derived (children) classes
//Interfaces have no implementation code
//(You can only inherit from one class, but you can implement as many as you want, interfaces dont share code)


//Protected keyword
//Used to make a member privated to external classes but public to derived classes
//If you declare a class member private, even classes that inherit from the class cannot see them
