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

            //EJERCICIO 7
            llenar(test);
            llenar(test2);
            Console.WriteLine("datos de la cola: ");
            informar(test);

            Console.WriteLine("dato de la pila: ");
            informar(test2);

            ColeccionMultiple Multiple = new ColeccionMultiple(test,test2);

            Console.WriteLine("ingresa un numero para ver si esta en la coleccion multiple:");
            int ing = (int.Parse(Console.ReadLine()));
            Comparable valor = new Numero(ing);
            Console.WriteLine(Multiple.contiene(valor));

            //EJERCICIO 9
            informar(Multiple);

            //EJERCICIO 13
            Pila Pila = new Pila();
            Cola Cola = new Cola();
            Multiple = new ColeccionMultiple(Pila, Cola);

            llenarPersonas(Pila);
            llenarPersonas(Cola);

            informar(Multiple);

            //EJERCICIO 17
            Pila = new Pila();
            Cola = new Cola();

            llenaAlumnos(Pila);
            llenaAlumnos(Cola);
            Multiple = new ColeccionMultiple(Pila,Cola);
            
            informarA(Multiple);


            //EJERCICIO 18 ALUMNO
           /* Alumno A1 = new Alumno(45,"Mario",55,7);
            Alumno A2 = new Alumno(55, "Julia", 55, 10); 

            Console.WriteLine("promedio es mayor: "+A1.sosMayor(A2)); //false
            Console.WriteLine("promedio es menor: " + A1.sosMenor(A2)); //true
            Console.WriteLine("promedio es igual: " + A1.sosIgual(A2)); //false*/

            Conjunto miConjunto = new Conjunto();

            Console.WriteLine("FIN...........");


        } //fin del main


        //EJERCICIO 16 practica 1
        public static void llenaAlumnos(Coleccionable c)
        {
            for (int i = 0; i < 20; i++)
            {
                Random dni = new Random();
                Random name = new Random();
                Random leg = new Random();
                Random prom = new Random();

                string[] nombres = new string[6] { "Gaby", "Maria", "Luigi", "Daisy", "Pedro", "Lucia" };
                int posi = name.Next(0, 5);

                string nomR = nombres[posi];
                int dniR = dni.Next(300, 500);
                int legR = leg.Next(5000, 6000);
                int promR = prom.Next(1, 10);
                //ejercicio 2 practica 2
                Alumno alumRandom = new Alumno(dniR, nomR, legR, promR);
                EstrategiaDeComparacion e = new estrategiaProm();
                alumRandom.setEstrategia(e);
                c.agregar(alumRandom);
            }

        }

        //EJERCICIO 12 practica 1
        public static void llenarPersonas(Coleccionable laColec)
        {
            Random dni = new Random();
            Random name = new Random();

            int dniAzar = dni.Next(300, 500);
            string[] nombres = new string[4] { "Gaby", "Maria", "Luigi", "Daisy" };
            int posi = name.Next(0, 3);

            string nomAzar = nombres[posi];

            for (int i = 0; i < 20; i++)
            {
                Comparable unTipoRandom = new Persona(nomAzar, dniAzar);
                laColec.agregar(unTipoRandom);
            }
        }

        //ejercicio 6 practica 1
        public static void informar(Coleccionable miCole)
        {
            Console.WriteLine("cant. elementos: " + miCole.cuantos());
            Console.WriteLine("elemento min: " + miCole.minimo());
            Console.WriteLine("elemento max: " + miCole.maximo());

            Console.WriteLine("buscar dato en esta coleccion: -->");
            int ing = (int.Parse(Console.ReadLine()));
            Comparable valor = new Numero(ing);

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

        //ejercicio 5 practica 1
        public static void llenar(Coleccionable miCole)
        {
            Random numb = new Random();

            for (int i = 0; i < 20; i++)
            {
                Comparable ele = new Numero(numb.Next(10, 50));
                miCole.agregar(ele);
            }

        }



    }


}
