using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Interfaces
    {
    }
}
//Same methods, but different results
//Interface- a reference type that specifies a set of function members but does not implement them,
// it is a empty method signature
//Any class that implements an interface is required to provide the code for the methods to make it work (like a contract)
//Key concept in polymorphic design and unit testing

//Interfaces can contain (data members, or static members)
//Interface may contain some function members (methods, properties, events, indexers),
//the declaration of the fuction members cannot contain code, a semicolon is put in place of the body (instead of curly braces)
//You should prefix interfaces with an uppercase I (IInterfacename)
//Interface declatations can have accessors,
//but the members are implicitly public (no access modifiers are permitted)




//Method signature- is a unique identification of a method for the C# compiler
//Consists of a method name and the type and kind (value, reference, or output) of each of its formal parameters. 
//Method signature does not include the return type