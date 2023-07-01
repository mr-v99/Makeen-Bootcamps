namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- the purpose of this program to print the first 10 even numbers

            //to display the header
            Console.WriteLine("1- Display the First 10 even numbers:");

            //count to stop when reaching 10
            int count = 0;
            int i = 0;
            while (count != 10)
            {
                //check if the  number is even or odd, if even  display it and increament count
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("2- Display the first 15 Fibonacci numbers");
            //2- the purpose of this program to print the first 15 Fibonacci numbers
            // Fibonacci for a specific number can be defind by the sum of the two previous numbers
            // For example: 0,1,1,2,3,5 where 0+1 is 1 and 1+1 is 2 and 2+3 is 5 and so on

            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int j = 2; j < 15; j++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }

            //3- The purpose of this program to print the first 10 powers of 2
            //we need to loop from 1 to 10 that represtns the powers
            // and then by using power method from Math package we can find the power of 2
            Console.WriteLine();
            Console.WriteLine("3- Display the first 10 powers of 2");
            double power = 1;
            for (double l = 1; l < 10; l++)
            {
                power = Math.Pow(2, l);
                Console.Write((power) + " ");

            }

            //4- The purpose of this program to find the largest number in an array of integers
            //suppose the first number is the largest, then loop the whole array, if a larger number found
            // update largest, otherwise complete
            Console.WriteLine();
            Console.WriteLine("4- Display the largest number in an array of integers");
            int[] arr = { 22, 1, 4, 35, 6, 53, 355, 3, 53, 0 };
            int largest = arr[0];
            for (int m = 0; m < arr.Length; m++)
            {
                if (arr[m] > largest)
                {
                    largest = arr[m];
                }
            }
            //5- The purpose of this program to print a pattern of stars 5x5
            //it require two loop, the fisrt loop for the rows and second loop for the columns
            Console.WriteLine();
            Console.WriteLine("5- Display a pattern of stars 5x5");
            for (int n = 0; n < 5; n++)
            {
                for (int k = 0; k < 5; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //6- The purpose of this program to check if a given number prime or not
            //it first loop from 2 to the number being cheked if prime or not
            //then if it find that any numbers smaller than the given number is divisible by 2
            //it exit the loop and consider it as not prime, otherwise it completes until the givin number
            Console.WriteLine("6- check if a given number is prime or not.\n");
            int num = 242;
            String result = "";
            for (int o = 2; o < num; o++)
            {
                if(num % o == 0)
                {
                    result = "not prime";
                    break;
                }
                else
                {
                    result = "not prime";
                }
            }
            Console.WriteLine($"{num} is {result} number");

            //7-Write a C# program to calculate the sum of the digits of a given integer
            Console.WriteLine("calculate the sum of the digits of a given integer");
            int number = 777;


            //Console.WriteLine($"The sum of the integer {number} is {splitDigits.Length}");

            //8- program to reverse a string..
            //Here I converted the string to indivisual characters and store it inside array
            //and then I used the built-in method Reverse to reverse the array
            //and then I converted back to a string
            String myName = "Ali";
            Char[] str = myName.ToCharArray(); 
            str.Reverse();
            result = new String(str);
            Console.WriteLine($"The string to be reversed {myName}\nThe Reversed name{result}");


            //10-Write a C# program to find the sum of all even numbers from 1 to 100.
            int sum = 0;
            for (int v = 1; v < 100; v++)
            {
                if(v % 2 == 0)
                {
                    sum += v;
                }
            }
            Console.WriteLine($"the sum of all even numbers from 1 to 100 is {sum}\n");

            //12-Write a C# program to sort an array of integers in ascending order
            Console.WriteLine("program to sort an array of integers in ascending order");

            //sample array
            int[] newArray = { 12,33,1,44,51,91,1 };

            //The array can be sorted by variuos algorithm such as selection sort, bubble sort, insertion sort
            //in this question i will use selection sort, where it consider the first number in the array
            //is the smallest one, then it loops the whole array looking for a smaller number,
            //if it find it, it will be swapped with the first number and so on

            for (int d=0; d< newArray.Length; d++)
            {
                int smallest = newArray[d];

                for(int f=d+1; f<newArray.Length; f++)
                {
                    if (newArray[f] < smallest)
                    {
                        int temp = newArray[f];
                        newArray[f] = newArray[d];
                        newArray[d] = temp;
                    }
                }
            }
            for(int q = 0; q < newArray.Length; q++)
            {
                Console.Write(newArray[q]+", ");
            }
            Console.WriteLine("\n");
        }


    }
}
