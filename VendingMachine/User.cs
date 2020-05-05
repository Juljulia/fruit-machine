namespace VendingMachine
{
    public class User 
    {
        public int CreditCard { get; set; }
        public User(int creditCard)
        {
            CreditCard = creditCard;
        }
    }
}