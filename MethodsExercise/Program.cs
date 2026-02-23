namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you have a pet"); // output
            Console.ReadLine(); // input
            Console.WriteLine("What type of pet do you have?"); // output
            string petType = Console.ReadLine(); // input
            Console.WriteLine("what is you pets name");
            string petName = Console.ReadLine();
            Console.WriteLine("How old is your pet?");
            string age = Console.ReadLine();
            Console.WriteLine("What color is your pet?");
            string petColor = Console.ReadLine();
            Console.WriteLine("What is yor pets favorite activity to do?");
            string activity= Console.ReadLine();
            Console.WriteLine($"So I see. You have a {petColor} {petType} named {petName}. They are {age} years old. Their favorite thing to do is {activity}.");
             
        }
    }
}
