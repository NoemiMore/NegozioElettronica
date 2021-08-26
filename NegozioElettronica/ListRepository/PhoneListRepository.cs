using NegozioElettronica.Entity;
using NegozioElettronica.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.ListRepository
{
    class PhoneListRepository : IPhoneDbManager
    {

        public static List<Phone> phones = new List<Phone>
        {
            new Phone ("Hawei", "p20", 10, 128, null),
            new Phone ("Iphone", "5", 8, 250, null),
            new Phone ("Iphone", "6", 5, 128, null)
        };



        public void Delete(Phone phone)
        {
            phones.Remove(phone);
                 
        }

        public List<Phone> Fetch()
        {
            return phones;
        }

        public Phone GetById(int? id)
        {
            return phones.Find(phone => phone.Id == id);
        }

        public void Insert(Phone phone)
        {
            phones.Add(phone);
        }

        public void Update(Phone phone)
        {
            Delete(GetById(phone.Id));
            Insert(phone);
                
        }
    }
}
