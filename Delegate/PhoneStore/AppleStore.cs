using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.PhoneStore
{
    public class AppleStore
    {
        public event Action<List<Phone>> notify;
        List<Phone> devices = new List<Phone>();

        public void PutNewPhones(List<Phone> phones)
        {
            devices.AddRange(phones);

            foreach (Phone phone in devices)
            {
                Console.WriteLine($"{phone.name} in store. You can buy for {phone.price} at AppleStore");
            }

            notify?.Invoke(devices);
        }
    }
}
