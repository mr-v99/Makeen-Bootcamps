namespace OOP_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//Question1");
            Rectangle rectangle = new Rectangle();
            Console.WriteLine($"The area of rectangle 1: {rectangle.getArea()}");
            Rectangle rectangle2 = new Rectangle();
            Console.WriteLine($"The area of rectangle 2: {rectangle2.getArea()}");


            Console.WriteLine("//Question2");
            Calculator calculator = new Calculator();
            Console.WriteLine($"1+2 = {calculator.add(1,2)}");
            Calculator calculator2= new Calculator();
            Console.WriteLine($"1+2+3 = {calculator2.add(1, 2,3)}");

            Console.WriteLine("//Question3");

        }
    }
}