using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Conjunto : Coleccionable , Iterable
    {
        private List<Comparable> elementos;

        public Conjunto()
        {
            elementos = new List<Comparable>();
        }

        public void queSoy() { Console.WriteLine("UN CONJUNTO"); }

        public Iterador crearIterador()
        {
            return new IteradorDeConjunto(this);
        }

        public Comparable elemento(int i)
        {
            return elementos[i];
        }


        public List<Comparable> getElemetos()
        {
            return elementos;
        }
        
        public void agregar(Comparable c)
        {
            if (!pertenece(c))     
                elementos.Add(c);
               
        }

        public bool pertenece(Comparable c)
        {
            return this.contiene(c);
        }

        public void muestrame()
        {
            foreach (var ele in elementos)
                Console.WriteLine(ele.ToString());
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

    }
}
