namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.OutputEncoding = System.Text.Encoding.UTF8;

           
            Func<double, double> discountCalculator = null;

           
            discountCalculator += price => price * 0.90;
            discountCalculator += price => price * 0.95;
            discountCalculator += price => price - 100;

           
          
            double currentPrice = 1000;
            Console.WriteLine($"Початкова ціна: {currentPrice} грн");

           
            Delegate[] delegates = discountCalculator.GetInvocationList();

          
            foreach (Func<double, double> discountMethod in delegates)
            {
               
                currentPrice = discountMethod(currentPrice);

                Console.WriteLine($"Ціна після застосування чергової знижки: {currentPrice} грн");
            }

            Console.WriteLine($"\nФінальна ціна до оплати: {currentPrice} грн");
        }
    }
}
