using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecomando
{
    internal class Telecomando
    {
        public bool stato;

        public int volume;

        public int canale;

        public string produttore;

        public string modello;

        public bool infrarossi;

        public bool bluetooth;

        public bool WiFi;

        public bool setSegnale(bool nuovoSegnale, bool a, bool b)
        {
            nuovoSegnale = true;
            return nuovoSegnale;

            a = false;
            return a;

            b = false;
            return b;
        }

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
