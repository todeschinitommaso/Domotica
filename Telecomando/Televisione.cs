using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecomando
{
    internal class Televisione
    {
        public bool stato;

        public int volume;

        public int canale;

        public string produttore;

        public string modello;

        public int setCanale(int nuovoCanale)
        {
            canale = nuovoCanale;
            return canale;
        }

        public int setVolume(int nuovoVolume)
        {
            volume = nuovoVolume;
            return volume;
        }

        public void accendi()
        {
            setStato(true);
        }
        public void spegni()
        {
            setStato(false);
        }

        private void setStato(bool nuovoStato)
        {
            stato = nuovoStato;
        }
    }
}
