namespace CraftCartCore.Services
{
    public class PaymentService
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Оплата на сумму {amount} руб.");
            return amount > 0;
        }
    }
}
