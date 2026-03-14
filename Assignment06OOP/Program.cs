using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment06OOP
{
    #region Q01 Part01
    //Abstraction is the process of exposing only what the user needs and hiding how it is implemented.

    //Main Focus_Hides_Tools_Level_Example

    //Abstraction

    //1_What an object does
    //2_Implementation complexity
    //3_Interface, Abstract class
    //4_Design level
    //5_INotification defines Send()
    // ////////////////////////////////////
    //Encapsulation

    //1_How data is protected
    //2_Internal state / data
    //3_Access modifiers, Properties
    //4_Implementation level
    //5_private _message with public getter

    //Real-World Example: Coffee Machine
    //What You Do

    //When you use a coffee machine, you usually:
    //Press the “Make Coffee” button
    //Wait a few seconds
    //Get your coffee

    //What You Don't Care About

    //heating the water
    //mixing water with coffee
    //controlling temperature and pressure


    //Encapsulation

    //Inside the coffee machine there are components like:
    //water heater
    //pump
    //coffee container
    //electronic controller
    //All these parts are hidden inside the machine
    //and cannot be accessed directly by the user.
    //You interact with them only through the machine’s buttons or interface.
    //This is Encapsulation because:
    //the internal data and components are protected
    //access is controlled through specific methods
    //Encapsulation focuses on protecting and controlling access to data.
    #endregion

    #region Q02 Part01
    //Abstract Class	

    //Can contain abstract methods and normal(implemented) methods
    //Can have fields/variables
    //A class can inherit only one abstract class
    //Members can have different access modifiers (public, protected, private)

    //Interface

    //Usually contains only method declarations (no implementation)
    //Cannot have instance fields
    //A class can implement multiple interfaces
    //Members are usually public by default

    //I will choose the abstract class when the classes are closely related
    //and share common code or fields.

    // I will choose the interface when I want to define a contract that different classes must implement
    // or when I need multiple inheritance.
    #endregion

    #region Q03 Part01
    //a) Can you write: Appliance a = new Appliance("LG"); ?
    //No
    //Why or why not
    //Appliance is an abstract class.
    //Abstract classes cannot be instantiated directly.
    //b) What is the difference between the three methods: PowerConsumption(), Status(), and Label()?
    //PowerConsumption()

    //abstract
    //No implementation in Appliance; derived classes must implement it

    //Status()
    //virtual
    // Has a default implementation("Standby"), but derived classes can override it

    //Label()
    //concrete(normal method)
    //Fully implemented; returns Brand +PowerConsumption()

    //Why did the designer make each one abstract, virtual, or concrete?
    //abstract very appliance has power consumption,
    //but it differs by type. Abstract forces derived classes to define it.
    //
    //virtual Most appliances can use "Standby" as default,
    //but some may have a specific status like "Washing" for a washing machine.
    //
    //concreteThe logic of showing the label is
    //the same for all appliances, no need to override.

    //c) If you call Status() on a Toaster object, what will it return? Why?
    //It will return Standby
    #endregion

    #region Q04 Part01
//a) What is a partial class?
      //A partial class allows you to split a single class definition across multiple files — the compiler merges them into one class.
//Why would a developer split Calculator into two files?
      //To organize code better: for example, keep core logic in one file and logging or additional features in another.
      //Makes large classes easier to maintain.
 //b) What is a partial method?
      //A partial method is declared in one part of a partial class and optionally implemented in another part.
 //What happens if the OnCalculated() implementation in Calculator.Logging.cs is deleted — will the code still compile?
      // yes the code will still compile.

 //Why?
      //OnCalculated() is a partial method.
      //Partial methods are optional: you can declare them in one part of a class and choose whether or not to implement them.
      //If the implementation in Calculator.Logging.cs is deleted:
      //The call to OnCalculated(LastResult) in Calculator.cs is ignored by the compiler.
       //There’s no error because the method is optional.
 //c) What is an extension method? 
       //An extension method lets you add new methods to an existing type without modifying its source code, without inheritance, and without recompiling.
    //What are the three rules for writing one?
       // static class_ static method_this on 1st param
 //d) What will the following code print?
       //Log: result = 20
      //$20.00






    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
