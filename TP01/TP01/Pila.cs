using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Pila : Coleccionable , Iterable
    {
        private List<Comparable> elementos;

        public Pila()
        {
            elementos = new List<Comparable>();
            
        }

        public void push(Comparable c)
        {
            elementos.Add(c);
        }

        public Iterador crearIterador()
        {
            return new IteradorDePila(this);
        }

        public Comparable pop()
        {
            Comparable e = elementos[elementos.Count - 1];
            elementos.RemoveAt(elementos.Count - 1);
            return e;
        }

        //implementar interfaz
        

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

        public Comparable elemento(int i)
        {
            return elementos[i];
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


        public void agregar(Comparable c)
        {
            elementos.Add(c);
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

    }
}
