using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica
{
    class Menu
    {

        internal static void Start()
        {
            bool continuare = true;

            do
            {
                Console.WriteLine("Premi 1 per vedere tutti i prodotti");
                Console.WriteLine("Premi 2 per vedere tutti i Pc");
                Console.WriteLine("Premi 3 per vedere tutti i telefoni");
                Console.WriteLine("Premi 4 per vedere tutte le tv");
                Console.WriteLine("Premi 5 per inserire un nuovo prodotto");
                Console.WriteLine("Premi 6 per modificare un prodotto");
                Console.WriteLine("Premi 7 per eliminare un prodotto");
                Console.WriteLine("Premi 8 per filtrare i cellulari per memoria superiore a quella scelta");
                Console.WriteLine("Premi 9 filtrare i pc per sistema operativo scelto dall'utente");
                Console.WriteLine("Premi 10 filtrare le tv per pollici uguali a quelli scelti dell'utente");
                Console.WriteLine("Premi 0 per uscire");
                Console.WriteLine();
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        DealerManager.ShowProduct();
                        break;
                    case "2":
                        DealerManager.ShowPc();
                        break;
                    case "3":
                        DealerManager.ShowPhone();
                        break;
                    case "4":
                        DealerManager.ShowTv();
                        break;
                    case "5":
                        DealerManager.InsertProduct();
                        break;
                    case "6":
                        DealerManager.UpdateProduct();
                        break;
                    case "7":
                        DealerManager.DeleteProduct();
                        break;
                    case "8":
                        DealerManager.FilterMemoryPhone();
                        break;
                    case "9":
                        DealerManager.FilterSystemOpPc();
                        break;
                    case "10":
                        DealerManager.FilterPolTv();
                        break;
                    case "0":
                        Console.WriteLine("Ciao alla prossima");
                        continuare = false;
                        break;
                    default:
                        Console.WriteLine("Scelta sbagliata riprova");
                        break;
                }
            } while (continuare);
        }



    }
}
