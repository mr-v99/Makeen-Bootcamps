namespace day3_practice
{
    internal class Program
    {
        int global = 3;
        int z = 6;
        static void Main(string[] args)
        {

            //Ternary operation: to check a condition if true or false and return a value based on the condition
            //syntax: (condition) ? value if true : value if false
            //example:
            int a = 5; int b = 10;
            String result = (a < b) ? "a is smalller" : "b is smaller";

            //arrays initialization and declaration
            //single dimension array, there is two main methods to initilize the array
            //the 1st one by using new key word, the size must be determined inside [ ]
            //example
            int[] newArr = new int[3] { 1, 2, 3 };

            //the second method by writing the values directly
            int[] arr = { 1, 2, 3, 4, 5, 6,7,8,9,10};

            //2-dimensionl array
            int[,] arr2 = new int[3, 3];
            arr2[0,0] = 1;
            arr2[1,1] = 2;
            arr2[2,2] = 3;


            //jagged arry
            int[][] arr3 = new int[3][] ;
            arr3[0] = new int[] { 1, 2, 3, };
            arr3[1] = new int[] { 1, 2, 3, 4,5};
            arr3[2] = new int[] { 1, 2, 3,4,5,6 };



            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0,1]);
            Console.WriteLine(arr3[0][1]);

            //array slicing

            int[] slice = arr[2..6];
            Console.WriteLine(slice[0]);

            int[] slice2 = arr[..3];
            Console.WriteLine(slice2[0]);

            int[] slice3 = arr[2..^2];
            Console.WriteLine(slice3.Length);

            int num = 4; //even or odd
            String result0 = (num % 2 == 0) ? "even" : "odd";
            Console.WriteLine($"number {num} is {result0}");

            String z = null;
            z = z ?? "Ali";
            Console.WriteLine(z);

            String w = null;
            Console.WriteLine(w?.ToUpper()); //conditional null

            int global = 5;
            Console.WriteLine(global);

            //prefix and postfix
            Console.WriteLine("------------");
            int x = 1;
            Console.WriteLine(x++);
            Console.WriteLine(++x);

            double final_grade = 85;
            
        }
    }
}
