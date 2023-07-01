namespace session5
{
    internal class Program
    {
        public static void PrintLine(int cnt = 15, string ptrn="$")
        {
            for (int i = 0; i <= cnt; i++)
            {
                Console.Write(ptrn);
            }
            Console.WriteLine();
        }

        public static void sumMulti(int x, int y, out int S, out int M)
        {
            S = x + y;
            M = x * y;
        }
        public static void swap(ref int x, ref int y)
        {
            int temp = x; x = y; y = temp;
        }
        static void Main(string[] args)
        {

            //Excercise1
            int x, y, z;
            Console.WriteLine("Enter First Number:");
            x = int.Parse(Console.ReadLine());
            PrintLine(5, "*");
            Console.WriteLine("Enter Second Number:");
            y = int.Parse(Console.ReadLine());
            PrintLine(6, "#");
            Console.WriteLine("Enter Third Number:");
            z = int.Parse(Console.ReadLine());
            PrintLine(7, "%");
            Console.WriteLine(x + y + z);
            PrintLine();


            //Excercise2
            int x, y, S, M;
            x = 5;
            y = 10;
            sumMulti(x, y, out S, out M);
            swap(ref S, ref M);
            Console.WriteLine($"Y = X*Y is {S}\n X= X+Y is {M}");

            //Exercise3
            Calculator calculator = new Calculator();

            int a, b;
            a = 10;
            b = 10;
            Console.WriteLine($"{a} + {b} = {calculator.add(a, b)}");


            double c, d;
            c = 12.5;
            d = 12.1;
            Console.WriteLine($"{c} + {d} = {calculator.add(a, b)}");


            string e, f;
            e = "Code";
            f = " Academy";
            Console.WriteLine($"{e} + {f} = {calculator.add(e, f)}");

            //Excercise4
            Person p1 = new Person(123, "Ali","AL-BADI", false, "Developer", "OMAN", 24);
            Console.WriteLine($"Person 1 \nname: {p1.firstName}\nlast name: {p1.lastName}");



        }
    }
}
/*
 * 
 */

/*
 * 
 */

/*
 * 
 */