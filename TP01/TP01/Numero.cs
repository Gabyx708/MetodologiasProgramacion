using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Numero : Comparable
    {
        private int valor;

        public Numero(int v)
        {
            valor = v;
        }

        public int getValor()
        {
            return valor;
        }

        public override string ToString()
        {
            return valor.ToString();
        }
        //implementar interfaz 
        public bool sosIgual(Comparable c)
        {
            return this.getValor() == ((Numero)c).getValor();
        }
        public bool sosMenor(Comparable c)
        {
            return this.getValor() < ((Numero)c).getValor();
        }
        public bool sosMayor(Comparable c)
        {
            return this.getValor() > ((Numero)c).getValor();
        }

    }
}
