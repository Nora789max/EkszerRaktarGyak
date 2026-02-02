using RaktarGyakorlas.Modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace RaktarGyakorlas.Repository
{
    public class UgyfelNyilvantartas
    {
        private List<Ugyfel> ugyfelLista;

        public UgyfelNyilvantartas()
        {
            ugyfelLista = new List<Ugyfel>();
            Seeder();
        }
        public void Seeder()
        {
            var sorok = File.ReadAllLines(@"C:\Data\ugyfelek.csv");
            foreach (var sor in sorok)
            {
               ugyfelLista.Add(new Ugyfel(sor));
            }
        }
        public void UjUgyfelFelvesz(string name, string email, string phone, string address)
        {
            var maxId = 1;
            if (ugyfelLista.Any())
            {
                maxId = ugyfelLista.Max(x => x.Id) + 1;
            }
            ugyfelLista.Add(new Ugyfel(maxId, name, email, phone, address));
        
        }
    }
}
