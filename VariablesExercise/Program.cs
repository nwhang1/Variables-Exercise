namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string catName = "Cinnamon";

            int catAge = 9;

            char excitement = '!';

            bool isHappy = true;

            double catFood = 3.5;

            decimal catHungry = 1.51M;

            

            Console.WriteLine($"My cat's name is {catName}, She is {catAge} years old {excitement} She eats a lot, {catFood} pounds of cat food to be exact. You might think it's a lot, and it's {isHappy}. However, if she doesn't eat at least {catHungry} pounds of cat food a day, she'll be annoying all night. ");
        }
    }
}
