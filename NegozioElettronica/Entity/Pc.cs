using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.Entity
{
    class Pc: Product
    {
        public SystemOp SyOperation { get; set; }
      public bool Touch { get; set; }


        //costruttori


        public Pc(string brand, string model, int quantityMagazine, SystemOp syOperation, bool touch , int? id) : base(brand, model, quantityMagazine, id)

        {
            SyOperation = syOperation;
            Touch = touch;


        }

        public Pc()
        {
        }

        public override string Print()
        {
            return $"{base.Print()}, {SyOperation}, {Touch}";
        }
    }

    enum SystemOp
    {
        Windows,
        Mac,
        Linux
    }
}
