using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Gerente : Persona , IObservador
    {   
        private int idGerente;
        private Conjunto mejores;
        public Gerente(string n,int d,int num) : base(n,d)
        {
            idGerente = num;
            mejores = new Conjunto();
        }

        public void venta(int monto,Vendedor v)
        {
            if(monto < 5000)
            {
                mejores.agregar(v);
                v.aumentaBonus();
            }
        }

        public void cerrar()
        {
            mejores.muestrame();
        }

        public void actualizar(IObservado o)
        {
            this.venta(1000,(Vendedor)o);
        }
    }
}
