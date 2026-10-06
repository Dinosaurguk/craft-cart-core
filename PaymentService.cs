namespace CraftCartCore.Services
{
    public class PaymentService
    {
        public bool ProcessPayment(decimal amount)
        {
            return amount > 0;
        }
    }
}
