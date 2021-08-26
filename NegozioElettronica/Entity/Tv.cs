using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.Entity
{
    class Tv: Product
    {
        public int Pollici { get; set; }

      
        
        
        //costruttori
        public Tv (string brand, string model, int quantityMagazine, int pollici ,int? id) : base(brand, model, quantityMagazine, id)

        {
            Pollici = pollici;


        }

        public Tv ()
        {
        }



        public override string Print()
        {
            return $"{base.Print()}, {Pollici}";
        }

    }
}
