using System;
using System.Collections.Generic;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTERFACEEEEES :D \n");

            Pila pila = new Pila();
            Cola cola = new Cola();
            Conjunto conjunto = new Conjunto();
            Diccionario dic = new Diccionario();

            llenar(pila,1);
            llenar(cola, 1);
            llenar(conjunto, 1);
            llenar(dic, 1);

            imprimirElementos(pila,2);
            imprimirElementos(cola, 1);
            imprimirElementos(conjunto, 3);
            imprimirElementos(dic, 4);

            conjunto = new Conjunto();
            llenar(conjunto, 1);
            EstrategiaDeComparacion e = new estrategiaDni();
            informar(conjunto,1);
            cambiarEstrategia(conjunto,e);
            informar(conjunto, 1);
            
            /*Pila Pila = new Pila();
            Cola Cola = new Cola();
            ColeccionMultiple Multiple = new ColeccionMultiple(Pila, Cola);

            llenar(Pila,1);
            llenar(Cola,1);

          

            
            Pila = new Pila();
            Cola = new Cola();

            Vendedor v1 = new Vendedor(4, "Laura", 100);
            Vendedor v2 = new Vendedor(5, "Mauro", 200);

            Gerente g1 = new Gerente("Lucia", 5, 10);
            Gerente g2 = new Gerente("Juan", 7, 18);

            v1.agregarObservador(g1);
            v1.agregarObservador(g2);

            v2.agregarObservador(g1);

            v1.quitarObservador(g1);
            v1.quitarObservador(g2);

            Cola = new Cola();
            llenar(Cola, 2);
            imprimirElementos(Cola,1);

            PRACTICA 2 -aun no funciona revisar
            Alumno A1 = new Alumno(45,"Mario",55,7);
            Alumno A2 = new Alumno(85, "Julia", 25, 10); /*

            Console.WriteLine("promedio es mayor: "+A1.sosMayor(A2)); 
            Console.WriteLine("promedio es menor: " + A1.sosMenor(A2)); 
            Console.WriteLine("promedio es igual: " + A1.sosIgual(A2)); 

            Conjunto miConjunto = new Conjunto();
            miConjunto.agregar(A1);
            miConjunto.agregar(A1);
            Console.WriteLine("pertenece?: "+miConjunto.pertenece(A1));
            
            Console.WriteLine("FIN...........");

            Console.WriteLine("DICCIONARIO........");

            Diccionario tester = new Diccionario();
            tester.agregar(A1,A2);
            tester.agregar(A1, A1);
            tester.revisar(); */




        } //fin del main



        //ejercicio 6 practica 3
        public static void llenar(Coleccionable c,int opcion) // 0-numero 1-alumno 2-vendedor
        {
            for (int i=0;i<20;i++)
            {
                c.agregar(FabricaDeComparables.crearAleatorio(opcion));
            }
        }

        
        public static void informar(Coleccionable miCole,int opcion)
        {
            Console.WriteLine("cant. elementos: " + miCole.cuantos());
            Console.WriteLine("elemento min: " + miCole.minimo());
            Console.WriteLine("elemento max: " + miCole.maximo());

            Console.WriteLine("buscar dato en esta coleccion: -->");
           
            Comparable valor = FabricaDeComparables.crearPorTeclado(opcion);

            if (miCole.contiene(valor))
            {
                Console.WriteLine("si esta \n");
            }
            else
            {
                Console.WriteLine("No esta \n");
            }
        }

        //EJERCICIO 7 practica 2
        public static void imprimirElementos(Coleccionable miColec,int opcion)
        {
            Iterador IT = null;

            switch (opcion)
            {
                case 1: IT = new IteradorDeCola((Cola)miColec); break;
                case 2: IT = new IteradorDePila((Pila)miColec); break;
                case 3: IT = new IteradorDeConjunto((Conjunto)miColec); break;
                case 4: IT = new IteradorDeDiccionario((Diccionario)miColec); break;
            }

            Console.WriteLine("ELEMENTOS EN LA COLECCION //////////////////////////// \n");

            while (! IT.fin())
            {
                Console.WriteLine(IT.actual());
                IT.siguiente();
            }
           
        }

        //revisar para crear una version generica
        public static void cambiarEstrategia(Conjunto miColec, EstrategiaDeComparacion estrategia)
        {
            foreach (var ele in miColec.getElemetos())
            {
                ((Alumno)ele).setEstrategia(estrategia);
            }
                 
        }

        //EJERCICIO 13 practica 3

        public static void jornadaDeVenta(Coleccionable vendedores)
        {
            
        }

  

    }


}
