using System;
using System.Collections.Generic;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTERFACEEEEES :D \n");
   
            Pila test = new Pila();
            Cola test2 = new Cola();

            
            llenar(test,0);
            llenar(test2,0);
            Console.WriteLine("datos de la cola: ");
            informar(test,0);

            Console.WriteLine("dato de la pila: ");
            informar(test2,0);

            ColeccionMultiple Multiple = new ColeccionMultiple(test,test2);

            Console.WriteLine("ingresa un numero para ver si esta en la coleccion multiple:");
            int ing = (int.Parse(Console.ReadLine()));
            Comparable valor = new Numero(ing);
            Console.WriteLine(Multiple.contiene(valor));

            //EJERCICIO 9
            informar(Multiple,0);

            //EJERCICIO 13
            Pila Pila = new Pila();
            Cola Cola = new Cola();
            Multiple = new ColeccionMultiple(Pila, Cola);

            llenar(Pila,1);
            llenar(Cola,1);

            informar(Multiple,1);

            //EJERCICIO 17
            Pila = new Pila();
            Cola = new Cola();

            llenar(Pila,1);
            llenar(Cola,1);
            Multiple = new ColeccionMultiple(Pila,Cola);
            
            informarA(Multiple);


           /* PRACTICA 2 -aun no funciona revisar
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


    

        public static void llenar(Coleccionable c,int opcion) // 0-numero 1-alumno
        {
            for (int i=0;i<20;i++)
            {
                c.agregar(FabricaDeComparables.crearAleatorio(opcion));
            }
        }

        //ejercicio 6 practica 1
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

        public static void informarA(Coleccionable miCole)
        {
            Console.WriteLine("cant. elementos: " + miCole.cuantos());
            Console.WriteLine("elemento min: " + miCole.minimo());
            Console.WriteLine("elemento max: " + miCole.maximo());

            Console.WriteLine("buscar dato en esta coleccion: -->");
            int ing = (int.Parse(Console.ReadLine()));
            Alumno aux = new Alumno(ing,"hi",ing,ing);

            if (miCole.contiene(aux))
            {
                Console.WriteLine("si esta \n");
            }
            else
            {
                Console.WriteLine("No esta \n");
            }
        }

   

    }


}
