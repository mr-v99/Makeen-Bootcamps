using System.Collections;
using System.Threading.Channels;

namespace day10
{
    internal class Program
    {

        
        
        static void Main(string[] args)
        {


            /*string option1 = "book new appointemnt";
            string option2 = "update appointment";


            Console.WriteLine($"Please select an option:\n{option1}\n{option2}");
            while (true)
            {
                string userOption = Console.ReadLine();

                if(userOption == "1")
                {
                    
                    Console.WriteLine("Please select a day from 1 (sunday) to 7 (friady):");
                    string userDay = Console.ReadLine();

                    if (userDay == "6" || userDay == "7")
                    {
                        Console.WriteLine($"{userDay} is Holiday, Please select another day");
                    }
                    else
                    {
                        Console.WriteLine("Please enter your name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please enter your age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter your relationship single/married: ");
                        string relationship = Console.ReadLine();
                        Console.WriteLine("is this the first time for you (y/n): ");
                        bool userFirst = false;
                        if(Console.ReadLine() == "y")
                        {
                            userFirst = true;
                        }
                        

                        Patient patient = new Patient(name, age, relationship, userFirst);

                        Console.WriteLine("Reservation Confirmation Details:" +
                            $"\nName: {patient.name}"+
                            $"\nAge: {patient.age}"+
                            $"\nRelationship: {patient.relationShip}"+
                            $"\nFirst time: {patient.firstVisit}"+
                            $"\appintment: {patient.age}")

                            
                            );
                    }

                }
            }*/


        }
    }
}