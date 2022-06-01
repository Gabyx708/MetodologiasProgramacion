using System;
using System.Collections.Generic;

namespace Clases{

    //ejercicio 1

    interface Comparable{

        bool sosIgual(Comparable c);

        bool sosMenor(Comparable c);

        bool sosMayor(Comparable c);
    }


    interface Coleccionable
    {
        int cuantos();

        Comparable minimo();

        Comparable maximo();

        void agregar(Comparable c);

        bool contiene(Comparable c);

    }

    //ejercicio 2

    class Numero: Comparable{

        private int valor;

        public Numero(int v){
            valor = v;
        }

        public int getValor(){
            return valor;
        }

        //implementacion comparable 
    }


    //ejercicio 4

    class Pila: Coleccionable
    {
        private List<Comparable> elementos;

        public Pila()
        {
            elementos = new List<Comparable>();
        }


    }

    class Program{

        public static void Main(string[] args){
            IComparable c1 , c2 , c3;

            c1 = new Numero(4);
            c2 = new Numero(5);
            c3 = new Numero(7);

            Console.WriteLine(c1.sosIgual(c3));
        }
    }

} //fin