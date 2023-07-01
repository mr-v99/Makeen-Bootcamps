namespace program.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * This is part1
             * explain how to install visual studio and explore it
             * 
             * solution acts like a container to hold all the file
             * when we want to use it without repeating 
             * 
             * namespace is created by developers to organize the classed and types
             * it allows them to use it in other namespaces
             * example: namespace prpgram.cs contains program class
             * 
             * C# Under the Hood explains how the C# code will be executed
             * First, the source code compiled to intermediate code that can
             * be either CIL or IL
             * then it will be transelated to CLR and get assembled to .exe or .dll to mechine code
             * */

            /* This is part2
             * display the data on the console by using Write and Writeline methods
             * and surrounding it by "" and ; at the end of the statement
             * example:
             */
            Console.WriteLine("This is introduction to c#.");

            /*
             * comments to describe the code to other developers
             * or to look it back when needed
             * comments are two types: single using // or multilines using /**/


            /*
             * varibles to declare a memory location to hold some data
             *Common Type and be eaither value type or reference type
             *value type using stack and can be of specific size only and it can be bool, all the numbers type and strcut
             *reference type using heap and can be of any size. it can be string, object, class and interface.
             *example of value and reference type
             *flag and succeeded are value type
             *obj and obj 2 are reference type
             */
            bool flag = true;
            bool succeeded = false;
            Object obj = new Object();
            Object obj2 = new Object();

            /*
             * when two references are initilized then one of them points 
             * to the other one it creats unreachable location
             * example
             */
            obj = obj2;

            /*
             * String Concatination and String enterplotation
             * are two methods used to combine two different strings
             * example
             */
            String name = "Code Academy";
            int rating = 5;

            //conc
            Console.WriteLine(name + "has rating of "+rating+" out of 5");

            //enter
            Console.WriteLine($"{name} has rating of {rating} out of 5");

            /*
             * the variables can be declared as var or dynamic
             * var can not be changed later and compiled at the compile time
             * dynamic can be changed later and comiled at the run time
             * examples
             */

            var age = 24;
            //age = 25 error
            dynamic day = "monday";
            day = "Tuesday";

            /*
             * part 3
             * expression and comparison
             * compararison used to determone if the value true or fasle
             * comparison using <, >, ==, >=, <=
             * XOR is true if the two values are different 
             * and false if the two values are same
             */


            //XOR
            Console.WriteLine(true ^ true); //fasle
            Console.WriteLine(true ^ false); //true
            Console.WriteLine(false ^ true); //true
            Console.WriteLine(false ^ false); //fasle




        }
    }
}
