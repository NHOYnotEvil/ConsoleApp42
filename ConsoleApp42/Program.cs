namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepInExample = 7;
            int startNumberExample = 5;
            int resultExample = 96;

            for (int i = startNumberExample; i <= resultExample; i += stepInExample)
            {
                Console.WriteLine(i);
            }
        }
    }
}