using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var bird1 = new Bird();
            bird1.Home = "henhouse";
            bird1.MainPredator = "fox";
            bird1.FavoriteFood = "bugs";
            bird1.Color = "white";
            bird1.Type = "chicken";
            bird1.CanFly = false;
            bird1.Sound = "bawk bawk";
            bird1.IsAnnoying = true;

            Console.WriteLine($"My family recently bought 8 {bird1.Color} {bird1.Type}s, they currently live in a {bird1.Home} we built in our backyard.");
            Console.WriteLine();

            Console.WriteLine($"One night i woke from the shrieking {bird1.Sound}s coming from the henhouse, a {bird1.MainPredator} had found its way inside.");
            Console.WriteLine($"I didn't think much of it. After all they could just fly away right? Unfortunately, the next morning i found out that was {bird1.CanFly}. Now we only have 7.");
            Console.WriteLine();

            Console.WriteLine($"I also didnt know that {bird1.Type}s liked to eat {bird1.FavoriteFood}, so while i was playing with my pet grasshopper outside one of them ate it.");
            Console.WriteLine($"When i told my sister how annoying they were she just nodded her head and said it was {bird1.IsAnnoying}.");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var snake = new Reptile();
            snake.Type = "corn snake";
            snake.Name = "Cora";
            snake.IsVenomous = false;
            snake.Look = "cute";
            snake.Home = "terrarium";
            snake.MainPredator = "bird";
            snake.FavoriteFood = "rats";
            snake.Color = "orange";

            Console.WriteLine("---------------------------------");
            Console.WriteLine($"I have an {snake.Color} pet {snake.Type} named {snake.Name}");
            Console.WriteLine($"I keep her in a {snake.Home} in my room. One of her favorite things to eat are {snake.FavoriteFood}");

            Console.WriteLine();
            Console.WriteLine($"I don't take her outside much, I'm afaid she might get eaten by a large {snake.MainPredator}");
            Console.WriteLine($"People often ask me if she's venomous, I always tell them that's {snake.IsVenomous}.");

            Console.WriteLine();
            Console.WriteLine($"I think my snake is {snake.Look}, even though most people are creeped out by her.");
        }
    }
}
