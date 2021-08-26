using NegozioElettronica.Entity;
using NegozioElettronica.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.AdoRepository
{
    class PhoneAdoRepository : IPhoneDbManager
    {

        // mi connetto ad DB  E le tengo costanti

        const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
                                         "Initial Catalog = NegozioElettronica;" +
                                         "Integrated Security = true;";

        const string _discriminator = "Phone";





        public void Delete(Phone t)
        {
            throw new NotImplementedException();
        }

        public List<Phone> Fetch()
        {
            throw new NotImplementedException();
        }

        public Phone GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Phone t)
        {
            throw new NotImplementedException();
        }

        public void Update(Phone t)
        {
            throw new NotImplementedException();
        }
    }
}
