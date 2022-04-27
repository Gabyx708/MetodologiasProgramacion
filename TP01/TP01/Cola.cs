using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Cola : Coleccionable , Iterable
    {
        private List<Comparable> elementos;

        public Cola()
        {
            elementos = new List<Comparable>();
        }

        public void agregar(Comparable c)
        {
            elementos.Add(c);
        }

        public Iterador crearIterador()
        {
            return new IteradorDeCola(this);
        }

        public Comparable elemento(int i)
        {
            return elementos[i];
        }

        public int cuantos()
        {
            return this.elementos.Count;
        }

        public Comparable minimo()
        {
            Comparable masChico = elementos[0];

            for (int i = 1; i < this.cuantos(); i++)
            {
                if (elementos[i].sosMenor(masChico))
                {
                    masChico = elementos[i];
                }
            }

            return masChico;
        }

        public Comparable maximo()
        {
            Comparable masGrande = elementos[0];

            for (int i = 1; i < this.cuantos(); i++)
            {
                if (elementos[i].sosMayor(masGrande))
                {
                    masGrande = elementos[i];
                }
            }

            return masGrande;
        }


        public bool contiene(Comparable c)
        {

            for (int i = 0; i < this.cuantos(); i++)
            {
                if (elementos[i].sosIgual(c))
                {
                    return true;
                }
            }

            return false;
        }

        public Comparable desencolar()
        {
            Comparable e = elementos[0];
            elementos.RemoveAt(0);
            return e;
        }

    }
}
