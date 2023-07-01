namespace Day8Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cashier c1 = new Cashier(new Cash(999.999m));
            Cashier c2 = new Cashier(new Visa(999.999m));
            Cashier c3 = new Cashier(new MasterCard(999.999m));

            c1.checkout();
            c2.checkout();
            c3.checkout();


        }
    }
}