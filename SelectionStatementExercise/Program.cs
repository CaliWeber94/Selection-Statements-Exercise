namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var r = new Random();
            int FaveNumber = r.Next(1, 20);
            Console.WriteLine("enter a number between 1 and 20");

            var userInput = int.Parse(Console.ReadLine());
            if (userInput > FaveNumber)
            {
                Console.WriteLine("Too High");
            }
            else if (userInput<FaveNumber)
            { 
                Console.WriteLine("Too Low"); 
            }
            else
            {
                Console.WriteLine("Correct, that is the number");
            }

        }
    }
}
