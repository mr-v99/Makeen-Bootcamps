using System.ComponentModel.DataAnnotations;

namespace Day11
{
    public delegate void RectangleHelper(double width, double height);
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Rectangle rect1 = new Rectangle(10,20);
            RectangleHelper rect2 = new RectangleHelper(rect1.getArea);

            //rect2 += rect1.getArea;
            rect2 += rect1.getParameter;
            rect2 += rect1.addition;
            rect2 += rect1.subtraction;
            rect2(10,20);*/

            /*//multiplication
            Money money1 = new Money(12);
            Money money2 = new Money(66);
            Money money3 = money1 * money2;
            Console.WriteLine(money3.amount);

            //divison
            Money money4 = money1 / money2;
            Console.WriteLine(money4.amount);

            //==
            bool money5 = money1 == money2;
            Console.WriteLine(money5);
            //!=
            bool money6 = money1 != money2;
            Console.WriteLine(money6);*/


            Stock s1= new Stock("Tesla");
            s1.Price = 100;



            s1.OnChangeStockPrice += S1_OnChangeStockPrice;

            s1.changePrice(-66);
            s1.changePrice(12);
            s1.changePrice(-33);
            s1.changePrice(77);
        }

        private static void S1_OnChangeStockPrice(Stock s, decimal preprice)
        {
            if(s.Price > preprice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{s.getName} :: {s.Price} ---> up");
            }
            else if (s.Price < preprice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{s.getName} :: {s.Price} ---> down");

            }
        }
    }
    


    class Stock
    {
        private string name;
        private decimal price;

        public delegate void ChangeStockPrice(Stock s, decimal preprice);
        public event ChangeStockPrice OnChangeStockPrice;
        public string getName => this.name;

        public Stock(string name)
        {
            this.name = name;
        }
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public void changePrice(decimal percentage)
        {
            decimal preprice = this.price;
            this.price += this.price * percentage;
            if(OnChangeStockPrice != null)
            {
                OnChangeStockPrice(this, preprice);
            }
        }
    }
    
    class Money
    {
        public double amount { get; set; }
        public Money(double amount)
        {
            this.amount = amount;
        }

        public static Money operator *(Money n, Money m)
        {
            double value = n.amount * m.amount;
            return new Money(value);
        }

        public static Money operator /(Money n, Money m)
        {
            double value = n.amount / m.amount;
            return new Money(value);
        }
        public static bool operator ==(Money n, Money m)
        {
            bool value = n.amount == m.amount;
            return value;
        }

        public static bool operator !=(Money n, Money m)
        {
            bool value = n.amount != m.amount;
            return value;
        }


    }
    class Rectangle
    {
        public double width { get; set; }
        public double height { get; set; }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

        }
        
        public void getArea(double width, double height)
        {
            Console.WriteLine($"The area is {width * height}");
        }

        public void getParameter(double width, double height)
        {
            Console.WriteLine($"The parameter is {2*(width + height)}");
        }

        public void addition(double width, double height)
        {
            Console.WriteLine($"The parameter is {2 * (width + height)}");
        }
        public void subtraction(double width, double height)
        {
            Console.WriteLine($"The subtraction is {width - height}");
        }
        public void division(double width, double height)
        {
            Console.WriteLine($"The division is {width / height}");
        }


    }
}