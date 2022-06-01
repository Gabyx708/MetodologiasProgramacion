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

    class IteradorDePila : Iterador
    {
        private Pila pila;
        private int indice;

        public IteradorDePila(Pila p)
        {
            pila = p;
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
            return indice == pila.cuantos();
        }
        public Comparable actual()
        {
            return pila.elemento(indice);
        }
    }

    class IteradorDeCola : Iterador
    {
        private Cola cola;
        private int indice;

        public IteradorDeCola(Cola c)
        {
            cola = c;
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
            return indice == cola.cuantos();
        }
        public Comparable actual()
        {
            return cola.elemento(indice);
        }
    }

    class IteradorDeConjunto: Iterador
    {
        private Conjunto conj;
        private int indice;

        public IteradorDeConjunto(Conjunto c)
        {
            conj = c;
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
            return indice == conj.cuantos();
        }
        public Comparable actual()
        {
            return conj.getElemetos()[indice];
        }
    }

    class IteradorDeDiccionario : Iterador
    {
        private Diccionario dic;
        private int indice;

        public IteradorDeDiccionario(Diccionario d)
        {
            dic = d;
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
            return indice == dic.cuantos();
        }
        public Comparable actual()
        {
            return dic.elemento(indice);
        }
    }



}
