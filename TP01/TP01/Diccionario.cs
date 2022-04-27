using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Diccionario
    {
        private Conjunto almacen;

        public Diccionario()
        {
            almacen = new Conjunto();
        }

        public void agregar(Comparable clave,Comparable valor)
        {
            claveValor nuevoEle = new claveValor(clave,valor);

            foreach (claveValor e in almacen.getElemetos())
            {
                if (e.getClave().Equals(clave))
                {
                    e.setValor(nuevoEle.getValor());
                }
                else
                {
                    almacen.agregar(nuevoEle);
                }
            }
            
          
        }

        public claveValor valorDe(Comparable key)
        {
            return null;
        }

        public void revisar()
        {
            almacen.muestrame();
        }
    }

    class claveValor : Comparable
    {
        Comparable clave,valor;

        public claveValor(Comparable c,Comparable v)
        {
            clave = c;
            valor = v;
        }

        public Comparable getClave() { return clave; }
        public Comparable getValor() { return valor; }

        public void setClave(Comparable k) { clave = k; }
        public void setValor(Comparable nV) { valor = nV; }

       
        public bool sosIgual(Comparable c)
        {
            return false;
        }

        public override string ToString()
        {
            return "--Clave: "+clave+" --Valor: "+valor;
        }
        public bool sosMenor(Comparable c)
        {
            return false;
        }

        public bool sosMayor(Comparable c)
        {
            return false;
         }
    }


}
