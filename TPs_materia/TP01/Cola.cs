using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Cola : Coleccionable , Iterable , IOrdenable
    {
        private List<Comparable> elementos;
        private IOrdenAula1 ordenInicio = null, ordenFin = null;
        private IOrdenAula2 ordenAlumno = null;

        public Cola()
        {
            elementos = new List<Comparable>();
        }

        public void queSoy() { Console.WriteLine("UNA COLA"); }

        //interfaz ordenable
        public void setOrdenInicio(IOrdenAula1 a)
        {
            ordenInicio = a;
        }
        public void setOrdenLlegaAlumno(IOrdenAula2 a2)
        {
            ordenAlumno = a2;
        }
        public void setOrdenAulaLLena(IOrdenAula1 a1)
        {
            ordenFin = a1;
        }

        public void agregar(Comparable c)
        {
            elementos.Add(c);

            if (elementos.Count == 1)
                if (ordenInicio != null)
                    ordenInicio.ejecutar();

            if (ordenAlumno != null)
                ordenAlumno.ejecutar(c);

            if (elementos.Count == 40)
                if (ordenFin != null)
                    ordenFin.ejecutar();
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
