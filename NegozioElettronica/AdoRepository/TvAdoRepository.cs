using NegozioElettronica.Entity;
using NegozioElettronica.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.AdoRepository
{
    class TvAdoRepository : ITvDbManager
    {

        // mi connetto ad DB  E le tengo costanti

        const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
                                         "Initial Catalog = NegozioElettronica;" +
                                         "Integrated Security = true;";

        const string _discriminator = "Tv";



        public void Delete(Tv t)
        {
            throw new NotImplementedException();
        }

        public List<Tv> Fetch()
        {
            throw new NotImplementedException();
        }

        public Tv GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Tv t)
        {
            throw new NotImplementedException();
        }

        public void Update(Tv t)
        {
            throw new NotImplementedException();
        }
    }
}
