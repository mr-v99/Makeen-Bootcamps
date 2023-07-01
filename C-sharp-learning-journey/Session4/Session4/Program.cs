namespace Session4
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployes = 0; 

            while (true)
            {
                Console.WriteLine("enter nuber of employes: ");
                
                string numberOfEmployesString = Console.ReadLine(); 

                if(int.TryParse(numberOfEmployesString, out var employes)) {
                    numberOfEmployes = employes;
                    break;
                }
                Console.WriteLine("invalid Input !!");
            }

            Employee[] employeesList = new Employee[numberOfEmployes];




            for (int i = 0; i < numberOfEmployes; i++)
            {
                Employee newEmploye = new Employee();

                Console.WriteLine($"enter employ {i+1} first name :");
                newEmploye.fname= Console.ReadLine();

                Console.WriteLine("enter last name :");
                newEmploye.fname = Console.ReadLine();

                Console.WriteLine("enter wage :");
                newEmploye.wage = double.Parse( Console.ReadLine());


                Console.WriteLine("enter loggedHours :");
                newEmploye.loggedHours = double.Parse(Console.ReadLine());
                int x = 18;
                newEmploye.add(ref x);
                Console.WriteLine(x);
                employeesList[i] = newEmploye;
            }


            foreach (Employee employee in employeesList)
            {

                double totalSalary = employee.wage * employee.loggedHours;
                double tax = totalSalary * Employee.TAX;
                double netSalary = totalSalary - tax;

                Console.WriteLine("*****************Enter information****************");
                Console.WriteLine($"Your Full name       : {employee.fname} {employee.lname}");
                Console.WriteLine($"Your total salary    : {totalSalary} OMR");
                Console.WriteLine($"Your tax             : {tax} OMR");
                Console.WriteLine($"Your netSalary       : {netSalary} OMR");
                Console.WriteLine("***************************************************");
            }


            Console.WriteLine("###  All rights reserved by Almundhar ###");



        }
    }
}