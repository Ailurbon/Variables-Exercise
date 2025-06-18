namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string catsName = "Casper";

            int catsAge = 3;

            char catsGender = 'M';

            bool catIsFed = true;

            double catsWeight = 100;

            decimal catsMoney = 0.00m;
            
            Console.WriteLine("Cat destroyer 9000 activated");
            Console.WriteLine("Finding nearest cat...");
            Console.WriteLine ($"Cat found, name is {catsName}, age is {catsAge}, gender is {catsGender}");
            Console.WriteLine("advancing towards cat");
            Console.WriteLine($"oh no it looks like this cat weighs at least {catsWeight} lb");
            Console.WriteLine("Cat hit me... going down...");
            Console.WriteLine("");
            Console.WriteLine($"Cat has gained 30 xp and ${catsMoney}");
        }
    }
}
