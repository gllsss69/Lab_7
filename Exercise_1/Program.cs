namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var actions = new List<Action>();

            for (int i = 1; i <= 5; i++)
            {

                actions.Add(() => Console.WriteLine(i));
            }

            foreach (var action in actions)
            {
                action();
            }
        }
    }
}
