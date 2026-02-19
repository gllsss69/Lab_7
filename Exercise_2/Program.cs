namespace Exercise_2
{
   
    public class BankTerminal
    {

        public event Action<int> OnMoneyWithDraw;

        public void WithDraw(int amount)
        {
            Console.WriteLine($"Термінал видає {amount} грн...");
            OnMoneyWithDraw.Invoke(amount);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BankTerminal terminal = new BankTerminal();
            terminal.OnMoneyWithDraw += amount => Console.WriteLine($"На ваш рахунок начислено {amount} грн.");
            //terminal.OnMoneyWithDraw = null;
            terminal.WithDraw(100);
        }
    }
}
