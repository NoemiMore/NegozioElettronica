using NegozioElettronica.Entity;
using NegozioElettronica.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica.ListRepository
{
    class TvListRepository : ITvDbManager
    {
        // creo la lista delle tv
        public static List<Tv> tvs = new List<Tv>
        {
            new Tv ("Panasonic", "Euroclass", 10, 12, null),
            new Tv ("Panasonic", "Trafic", 8, 65, null),
            new Tv ("Eric", "Talento", 12, 32, null)
        };




        public void Delete(Tv tv)
        {
            tvs.Remove(tv);
        }

        public List<Tv> Fetch()
        {
            return tvs;
        }

        public Tv GetById(int? id)
        {
            return tvs.Find(tv => tv.Id == id);
        }

        public void Insert(Tv tv)
        {
            tvs.Add(tv);
        }

        public void Update(Tv tv)
        {
            Delete(GetById(tv.Id));
            Insert(tv);
                 
        }
    }
}
