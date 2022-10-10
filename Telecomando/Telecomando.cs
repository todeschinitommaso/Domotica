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

        public bool volume;

        public string produttore;

        public string modello;

        public class Segnale
        {
            bool infrarossi;

            bool bluetooth;

            bool WiFi;
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
