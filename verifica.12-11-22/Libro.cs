using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifica._12_11_22
{
    internal class Libro
    {
        private string autore;
        private string titolo;
        private int annoPubblicazione;
        private string editore;
        private int numeroPagine;

        private string getAutore()
        {
            return autore;
        }

        private string getTitolo()
        {
            return titolo;
        }

        private int getAnnoPubblicazioine()
        {
            return annoPubblicazione;
        }

        private string getEditore()
        {
            return editore;
        }

        private int getNumeroPagine()
        {
            return numeroPagine;
        }

        private void setPagine(int pagine)
        {
            this.numeroPagine = pagine;
        }


    }
}
