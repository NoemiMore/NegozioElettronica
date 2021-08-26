using NegozioElettronica.Entity;
using NegozioElettronica.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.ListRepository
{
    class PcListRepository : IPcDbManager
    {

        public static List<Pc> pcs = new List<Pc>
        {
            new Pc ("Dell", "p20", 10, SystemOp.Windows, true, null),
            new Pc ("Mac", "5", 8,  SystemOp.Linux, false, null),
            new Pc ("Mac", "6", 5, SystemOp.Mac , true, null)
        };



        public void Delete(Pc pc)
        {
            pcs.Remove(pc);
        }

        public List<Pc> Fetch()
        {
            return pcs;
        }

        public Pc GetById(int? id)
        {
            return pcs.Find(pc => pc.Id == id);
        }

        public void Insert(Pc pc)
        {
            pcs.Add(pc);
        }

        public void Update(Pc pc)
        {
            Delete(GetById(pc.Id));
            Insert(pc);
        }
    }
}
