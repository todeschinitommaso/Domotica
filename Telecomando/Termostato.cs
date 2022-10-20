using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecomando
{
    internal class Termostato
    {
        private bool stato;

        private int temperatura;

        private string produttore;

        private string modello;

        private string id;

        public void on()
        {
            setStato(true);
        }

        public void off()
        {
            setStato(false);
        }

        private void setStato(bool newStato)
        {
            stato = newStato;
        }

        public bool getStato()
        {
            return stato;
        }

        public bool invert()
        {
            setStato(!stato);
            return stato;
        }

        public void setTemp(int newTemp)
        {
            temperatura = newTemp;
        }

        public int getTemp()
        {
            return temperatura;
        }
       
    }
}
