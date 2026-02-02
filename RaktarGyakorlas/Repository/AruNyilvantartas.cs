using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaktarGyakorlas.Modell;

namespace RaktarGyakorlas.Repository
{
    public class AruNyilvantartas
    {
        private List<Aru> aruLista;

        public AruNyilvantartas()
        {
            aruLista = new List<Aru>();
            Seeder();
        }
        public void Seeder()
        {
            var sorok = File.ReadAllLines(@"C:\Data\ekszerek.csv");
            foreach (var sor in sorok)
            {
                aruLista.Add(new Aru(sor));
            }
        }
        public void UjaruFelvesz(string title, string description, decimal price)
        {
            var maxId = 1;
            if (aruLista.Any())
            {
                maxId = aruLista.Max(x => x.Id)+1;
            }
            aruLista.Add(new Aru(maxId, title, description, price));
            
        }
        public List<Aru> OsszesAruLekerdez() 
        {
            return aruLista;
        }

        //public Modell.Aru? AruLekerdezIdAlapjan(int id) { }
        //public Modell.Aru? AruLekerdezTitleAlapjan(string title) { }
        //public bool AruTorleseIdAlapjan(int id) { }
        //public bool AruModositasaIdAlapjan(int id, string title, string description, decimal price) { }

    }
}
