namespace BillingApi.DTOs
{
    public class PaymentInformationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Amount { get; set; }
        public int AccountNumber { get; set; }
    }
}
