namespace CraftCartCore.Services
{
    public class PaymentService
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Оплата принята: {amount} руб.");
            return amount > 0;
        }
    }
}