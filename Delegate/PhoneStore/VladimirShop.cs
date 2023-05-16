namespace Delegate.PhoneStore
{
    public class VladimirShop
    {
        public void SellNotification(List<Phone> phones)
        {
            foreach (Phone phone in phones)
            {
                Console.WriteLine($"\n{phone.name} in store. You can buy only TODAY for {phone.price + 299.99} at VladimirShop");
            }

        }
    }
}
