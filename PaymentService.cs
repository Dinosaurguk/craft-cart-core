namespace CraftCartCore.Services
{
    public class PaymentService
    {
        public bool ProcessPayment(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Сумма должна быть > 0");
            Console.WriteLine($"Оплата принята: {amount} руб.");
            return true;
        }
    }
}