using NegozioElettronica.Entity;
using NegozioElettronica.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.ListRepository
{
    class ProductListRepository : IProductDbManager
    {

        // qui creo una lista prodotti che unisce tutte le altre liste figlie
        static List<Product> products = new List<Product>();

       
  
       public static PcListRepository pcRepository = new PcListRepository();
        public static PhoneListRepository phoneRepository = new PhoneListRepository();
        public static TvListRepository tvRepository = new TvListRepository();
      




        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> Fetch()
            // in questo metodo dice di pulire la tabella se la conta dei prodotti è maggiore di 0
            // e di aggiungere poi tutti i prodotti delle singole entità. Torna una lista di prodotti
        {
            if (products.Count() > 0)
            {
                products.Clear();
            }

            products.AddRange(pcRepository.Fetch());
            products.AddRange(phoneRepository.Fetch());
            products.AddRange(tvRepository.Fetch());

            return products;
        }

        public Product GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
