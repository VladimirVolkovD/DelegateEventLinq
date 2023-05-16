namespace Delegate.PhoneStore
{
    public class IvanShop
    {
        public void SellNotification(List<Phone> phones)
        {
            foreach (Phone phone in phones)
            {
                Console.WriteLine($"\n{phone.name} only TODAY for {phone.price + 269.99} at IvanShop");
            }

        }
    }
}
