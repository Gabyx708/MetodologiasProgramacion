using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class IteradorDeLista : Iterador
    {
        private List<Comparable> lista;
        private int indice;

        public IteradorDeLista(List<Comparable> p)
        {
            lista = p;
            indice = 0;
        }
        public void primero()
        {
            indice = 0;
        }
        public void siguiente()
        {
            indice++;
        }
        public bool fin()
        {
            return indice == lista.Count;
        }
         public Comparable actual()
        {
            return lista[indice];
        }
    }
}
