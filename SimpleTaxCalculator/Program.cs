namespace SimpleTaxCal
{
    internal class SimpleTaxCal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Tax Calculator");
            Console.WriteLine("----------------------");

            Console.Write("Enter the Tax Rate: ");
            if (!int.TryParse(Console.ReadLine(), out var tax) || tax <= 0)
            {
                Console.WriteLine("Please enter a valid tax rate greater than 0.");
                return;
            }

            Console.Write("Enter the amount: ");
            if (!int.TryParse(Console.ReadLine(), out var amount) || amount < 0)
            {
                Console.WriteLine("Please enter a valid amount greater than or equal to 0.");
                return;
            }

            var taxAmount = amount * tax / 100;
            var annualTax = taxAmount * 12;
            var totalAmount = amount + taxAmount;
            var annualAmount = totalAmount * 12;

            Console.WriteLine("\nMonthly Tax Details:");
            Console.WriteLine($"Tax Amount: {taxAmount:C}");
            Console.WriteLine($"Total Amount: {totalAmount:C}");

            Console.WriteLine("\nAnnual Tax Details:");
            Console.WriteLine($"Tax Amount: {annualTax:C}");
            Console.WriteLine($"Total Amount: {annualAmount:C}");
        }
    }
}
