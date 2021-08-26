using NegozioElettronica.Entity;
using NegozioElettronica.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.AdoRepository
{
    class ProductAdoRepository : IProductDbManager
    {
        public static PcAdoRepository pcRepository = new PcAdoRepository();
        public static PhoneAdoRepository phoneRepository = new PhoneAdoRepository();
        public static TvAdoRepository tvRepository = new TvAdoRepository();





        public void Delete(Product t)
        {
            throw new NotImplementedException();
        }

       
        
        // nella fetch prodotti  aggiungo ogni lista delle diverse entità e mi ritornano cosi tutti i prodotti insieme
        public List<Product> Fetch()
        {
            List<Product> Products = new List<Product>();

            Products.AddRange(pcRepository.Fetch());
            Products.AddRange(phoneRepository.Fetch());
            Products.AddRange(tvRepository.Fetch());

            return Products;
        }

        public Product GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Product t)
        {
            throw new NotImplementedException();
        }

        public void Update(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
