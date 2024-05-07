using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Capolavoro.fighter;

namespace Capolavoro
{
    internal class tournament
    {
        public class Tournament
        {
            public List<Fighter> Fighters { get; set; }
            public List<match> Matches { get; set; }

            public Tournament()
            {
                Fighters = new List<Fighter>();
                Matches = new List<match>();
               
            }

            // Metodi per gestire il torneo (aggiunta di combattenti, creazione di incontri, registrazione dei risultati, serializzazione, deserializzazione, ecc.)
            // push test by iannelli
        }
    }
}
