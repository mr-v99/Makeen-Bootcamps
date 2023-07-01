namespace encaps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.setActNum(1111111111);
            account.setBalance(500);

            Console.WriteLine($"Welcome to Bank\nAccount#: {account.getActNum}\nBalance: {account.getBalance}" + 
                $"\nSelect the service: 1) withdraw 2)deposit");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount: ");

            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (choice == 1)
            {
                account.withdraw(amount);
            }
            else
            {
                account.deposit(amount);
            }
        }
    }
}
/*
 * Example 1:
 * Person p1 = new Person();
            p1.setFname("Ali");
            p1.setLname("Al-Badi");
            p1.setSalary(200);
            p1.setRelationshipState("salary");
            Console.WriteLine(p1.printData());

            Console.WriteLine("Enter the year of birth:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your age: {p1.calAge(year)} years.");
 * 
 */