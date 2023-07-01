namespace assignment3_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question2: test the play() and stop method()
            MusicPlayer player = new MusicPlayer();
            Console.WriteLine(player.Play());
            Console.WriteLine(player.Stop());

            //Question3: test the Resize() method
            Rectangle rectangle = new Rectangle(4);
            Console.WriteLine(rectangle.Resize(2,"increase"));

            //Question4: test Log() method
            ConsoleLogger logger = new ConsoleLogger();
            logger.log("This is ConsoleLogger");
            FileLogger logger2 = new FileLogger();
            logger2.log("This is FileLogger");
            //Question5: test the MoveUp, MoveDown, MoveRight, MoveLeft
            Player player1 = new Player(5,5); //current position
            player1.MoveLeft(10);
            Console.WriteLine($"The Player Current Postion is ({player1.x},{player1.y})");
            player1.MoveUp(13);
            Console.WriteLine($"The Player Current Postion is ({player1.x},{player1.y})");
            player1.MoveDown(7);
            Console.WriteLine($"The Player Current Postion is ({player1.x},{player1.y})");
            player1.MoveRight(3);
            Console.WriteLine($"The Player Current Postion is ({player1.x},{player1.y})");




        }
    }
}