//Welcome to the syntax tutorial. In this tutorial, we will explain the basic syntax of C#. 
//Please read the comments to see how the syntax works.


using System; //this will always appear before the namespace of our code. We are "using" the "Systems" found in the C# systems namespace.

namespace functions // the "namespace" is used to organize and call out the classes inside of it globally. It holds your classes 
{
    class functions // this holds how our code will work. This allows for the data and methods to be able to function in our code. 
    {
        static void Main(string[] args) // so this has alot of things to say here but in summary its the main method (Everything inside will run)
                                        /* static means that the Main method can be called without calling an object for it
                                            void means that the main will not return anything
                                            Main() is just the name of the method
                                            String []args is a bit complicated but it reruns whatever in mai as arguments that, if passes, will allow for it to display  */
        {
                Console.WriteLine("Hello World!"); // Console is a class inside the system, Writeline does exactly what it says, it writes whatever is inside the () in a new line
                Console.Write("Hello Again World!"); // Write is the same as WriteLine but...
                Console.Write("Goodbye World!"); // it does not set the code into a new line
                // Please note theat we use the semicolon(;) in this language to break up our code funtionality. 
        }
    }
}