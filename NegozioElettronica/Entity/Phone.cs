using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.Entity
{
    class Phone: Product
    {
        public int MemoriGB { get; set; }


        // costruttori

        public Phone (string brand, string model, int quantityMagazine, int memoriGB, int? id) : base(brand, model, quantityMagazine, id)

        {
            MemoriGB = memoriGB;


        }

        public Phone()
        {
        }



        public override string Print()
        {
            return $"{base.Print()}, {MemoriGB}";
        }
    }
}
