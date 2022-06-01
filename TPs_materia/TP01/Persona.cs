using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    //EJERCICIO 11

    class Persona : Comparable
    {
        private string nombre;
        private int dni;

        public Persona(string N, int D)
        {
            nombre = N;
            dni = D;
        }

        public int getDNI()
        {
            return dni;
        }

        public void setNombre(string n)
        {
            nombre = n;
        }

        public string getNombre()
        {
            return nombre;
        }

        public override string ToString()
        {
            return getNombre() + " ----- " + getDNI();
        }

        //interfaz

        public virtual bool sosIgual(Comparable c)
        {
            return this.dni == ((Numero)c).getValor();
        }
        public virtual bool sosMenor(Comparable c)
        {
            return this.dni < ((Persona)c).getDNI();
        }
        public virtual bool sosMayor(Comparable c)
        {
            return this.dni > ((Persona)c).getDNI();
        }
    }
}
