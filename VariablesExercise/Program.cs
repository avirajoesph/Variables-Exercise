namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int cupcake = 5;
            char jack = 'j';
            bool uphill = true;
            double time = 2.2;
            decimal feet = 5.5m;
            string name = "jill";

            Console.WriteLine($"{jack} and {name} walked uphill {feet} feet and it took them {time} minutes" +
                $" and they bought {cupcake} cupcakes And its {uphill} they made it back downhill ");
        }
    }
}
