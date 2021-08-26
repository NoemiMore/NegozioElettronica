using NegozioElettronica.AdoRepository;
using NegozioElettronica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica
{
    class DealerManager
    {
        // qui chiamo le liste create sia statiche che  quelle con ado facendo attenzione
        // a chiamarle tutte uguali per nn cambiare nient'altro

        // i repository che chiamano le classi con le liste statiche
        //public static PcListRepository pcRepository = new PcListRepository();
        //public static PhoneListRepository phoneRepository = new PhoneListRepository();
        //public static ProductListRepository productRepository = new ProductListRepository();
        //public static TvListRepository tvRepository = new TvListRepository();

        // i repository che chiamano le classi con ado 
        public static ProductAdoRepository productRepository = new ProductAdoRepository();
        public static PcAdoRepository pcRepository = new PcAdoRepository();
        public static TvAdoRepository tvRepository = new TvAdoRepository();
        public static PhoneAdoRepository phoneRepository = new PhoneAdoRepository();







        internal static void ShowProduct()
        {
            List<Product> products = productRepository.Fetch();
            foreach (var product in products)
            {
                Console.WriteLine(product.Print());
            }
        }

        internal static void ShowPc()
        {
            List<Pc> pcs = pcRepository.Fetch();
            foreach (var pc in pcs)
            {
                Console.WriteLine(pc.Print());
            }
        }

        internal static void ShowPhone()
        {
            List<Phone> phones = phoneRepository.Fetch();
            foreach (var phone in phones)
            { 
                Console.WriteLine(phone.Print());
            }
        }

        internal static void ShowTv()
        {
            List<Tv> tvs = tvRepository.Fetch();
            foreach (var tv in tvs)
            {
                Console.WriteLine(tv.Print());

            }
        }

        internal static void InsertProduct()
        {
            int tipoProduct;
            bool isInt;

            do
            {
                Console.WriteLine("Che prodotto vuoi inserire?");
                Console.WriteLine("Premi 1 per inserire una tv");
                Console.WriteLine("Premi 2 per inserire un phone");
                Console.WriteLine("Premi 3 per inserire un pc");

                isInt = int.TryParse(Console.ReadLine(), out tipoProduct);

            } while (!isInt || tipoProduct <= 0 || tipoProduct >= 4);

            switch (tipoProduct)
            {
                case 1:
                    Tv tv = InsertTv();
                    tvRepository.Delete(tv);
                    break;
                case 2:
                   Phone phone = InsertPhone();
                    phoneRepository.Delete(phone);
                    break;
                case 3:
                    Pc pc  = InsertPc();
                    pcRepository.Delete(pc);
                    break;
            }
        }

        private static Pc InsertPc()
        {
            throw new NotImplementedException();
        }

        private static Phone InsertPhone()
        {
            throw new NotImplementedException();
        }

        private static Tv InsertTv()
        {
            throw new NotImplementedException();
        }

        internal static void UpdateProduct()
        {
            throw new NotImplementedException();
        }

        internal static void DeleteProduct()
        {
            throw new NotImplementedException();
        }

        internal static void FilterMemoryPhone()
        {
            throw new NotImplementedException();
        }

       

        internal static void FilterSystemOpPc()
        {
            throw new NotImplementedException();
        }


        internal static void FilterPolTv()
        {
            throw new NotImplementedException();
        }
    }
}
