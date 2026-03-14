using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
