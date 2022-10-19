namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Exercise 1
            //Name:
            //Favorite Color:
            //Favorite Animal:
            //Favorite Band:

            Console.WriteLine("Hello, what is your name?");

            var userName = Console.ReadLine();


            Console.WriteLine($"Hi, {userName}.  What is your favorite color?");
            var color = Console.ReadLine();


            Console.WriteLine($"{color} is a pretty color!  What is your favorite animal?");
            var animal = Console.ReadLine();


            Console.WriteLine("Great!  Now who is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}!  Here is your profile answers");
            Console.WriteLine("_____________________________________");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite animal: {animal}");
            Console.WriteLine($"Favorite band: {band}");


           

        }
    }
}

     










        

    








