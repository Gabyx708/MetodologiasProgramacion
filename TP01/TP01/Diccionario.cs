﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Diccionario : Coleccionable , Iterable
    {
        private Conjunto almacen;

        public Diccionario()
        {
            almacen = new Conjunto();
        }

        public void queSoy() { Console.WriteLine("UN DICCIONARIO"); }
        public Iterador crearIterador()
        {
            return new IteradorDeLista(almacen.getElemetos());
        }

        public void agregar(Comparable clave,Comparable valor)
        {
            claveValor nuevoEle = new claveValor(clave,valor);

            foreach (claveValor e in almacen.getElemetos())
            {
                if (e.getClave().sosIgual(clave))
                {
                    e.setValor(nuevoEle.getValor());
                    break;
                }
                else
                {
                    almacen.agregar(nuevoEle);
                }
            }
            
          
        }

        public void agregar(Comparable n)
        {
            claveValor ficticia = new claveValor(null,null);

            almacen.agregar(n);
        }

        public claveValor valorDe(Comparable key)
        {
            foreach(claveValor x in almacen.getElemetos())
            {
                if (x.getClave().sosIgual(key))
                {
                    return x;
                }
            }
            return null;
        }

        public void revisar()
        {
            almacen.muestrame();
        }

        public int cuantos()
        {
            return this.almacen.cuantos();
        }

        public Comparable minimo()
        {
            Comparable masChico = almacen.getElemetos()[0];

            for (int i = 1; i < this.cuantos(); i++)
            {
                if (almacen.getElemetos()[i].sosMenor(masChico))
                {
                    masChico = almacen.getElemetos()[i];
                }
            }

            return masChico;
        }

        public Comparable maximo()
        {
            Comparable masGrande = almacen.getElemetos()[0];

            for (int i = 1; i < this.cuantos(); i++)
            {
                if (almacen.getElemetos()[i].sosMayor(masGrande))
                {
                    masGrande = almacen.getElemetos()[i];
                }
            }

            return masGrande;
        }

        public bool contiene(Comparable c)
        {
            for (int i = 0; i < this.cuantos(); i++)
            {
                if (almacen.getElemetos()[i].sosIgual(c))
                {
                    return true;
                }
            }

            return false;
        }

        public Comparable elemento(int i)
        {
            return almacen.getElemetos()[i];
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
            return this.sosIgual(c);
        }

        public override string ToString()
        {
            return "--Clave: "+clave+" --Valor: "+valor;
        }
        public bool sosMenor(Comparable c)
        {
            return this.sosMenor(c);
        }

        public bool sosMayor(Comparable c)
        {
            return this.sosMayor(c);
         }
    }


}
