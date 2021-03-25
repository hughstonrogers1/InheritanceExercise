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
            Bird bird = new Bird();

            bird.Name = "Hawk";
            bird.BeakType = "Hooked";
            bird.FoodType = "Carnivore";
            bird.DoesItFly = "Yes";
            bird.Color = "Red";
            bird.HowFood = "Hunts";
            bird.Region = "Southwest";
            bird.Speed = 150;

            Console.WriteLine($"The {bird.Color} {bird.Name} is a {bird.FoodType} who {bird.HowFood} its food with its {bird.BeakType}.\n " +
                $"It is from the {bird.Region}. Is this bird able to fly: {bird.DoesItFly}. The {bird.Name} is able fly at {bird.Speed} MPH.");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Reptile reptile = new Reptile();

            reptile.Name = "Alligator";
            reptile.Region = "South";
            reptile.FoodType = "Carnivore";
            reptile.DoesItHaveClaws = "Yes";
            reptile.Legs = 4;
            reptile.IsItFast = "Yes";
            reptile.Color = "Green";
            reptile.DoesItSwim = "Yes";

            Console.WriteLine($"The {reptile.Name} is a {reptile.Color} {reptile.FoodType} who is from the {reptile.Region}. It has {reptile.Legs}, {reptile.DoesItHaveClaws} to claws!\n " +
                $"{reptile.DoesItSwim} it does swim. {reptile.IsItFast} it is fast."); 
            

        }
    }
}
