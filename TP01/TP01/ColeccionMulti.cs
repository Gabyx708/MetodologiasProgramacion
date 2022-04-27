using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    //EJERCICIO 8
    class ColeccionMultiple : Coleccionable
    {
        Pila miPila;
        Cola miCola;

        public ColeccionMultiple(Pila P, Cola C)
        {
            miPila = P;
            miCola = C;
        }

        public Comparable elemento(int i)
        {
            return null;
        }

        public int cuantos()
        {
            int total = miPila.cuantos() + miCola.cuantos();
            return total;
        }

        public Comparable minimo()
        {
            if (miPila.minimo().sosMenor(miCola.minimo()))
            {
                return miPila.minimo();
            }

            return miCola.minimo();
        }

        public Comparable maximo()
        {
            if (miPila.maximo().sosMayor(miCola.maximo()))
            {
                return miPila.maximo();
            }

            return miCola.maximo();
        }

        public bool contiene(Comparable c)
        {
            if (miCola.contiene(c) || miPila.contiene(c))
            {
                return true;
            }

            return false;
        }
        public void agregar(Comparable c)
        {
            Console.WriteLine("zzz");
        }
    }
}
