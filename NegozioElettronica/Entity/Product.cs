using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.Entity
{
    class Product
    {
       

             public string Brand { get; set; }
        public string Model { get; set; }
        public int QuantityMagazine { get; set; }
        public int? Id { get; set; }



        //costruttori

        public Product(string brand, string model, int quantityMagazine, int? id)
         
        {
            Brand = brand;
            Model = model;
            QuantityMagazine = quantityMagazine;
            Id = id;



        }

        public Product()
        {
        }



        // fare funzione di stampa

        public virtual string Print()
        {
            return $"{Brand}, {Model}, { QuantityMagazine } ";
        }
    }
}
