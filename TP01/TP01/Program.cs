using System;
using System.Collections.Generic;
using MetodologíasDeProgramaciónI;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTERFACEEEEES :D \n");
                   
            //practica 3 ejercicio 14
            Cola test = new Cola();
            llenar(test,2);
            Gerente gerent = new Gerente("Mario",45,01);

            Iterador recorre = test.crearIterador();

            while (!recorre.fin())
            {
                ((Vendedor)recorre.actual()).agregarObservador(gerent);
                recorre.siguiente();
            }

            jornadaDeVenta(test.crearIterador());
           

            gerent.cerrar();

            ejercicio4();

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
        public static void imprimirElementos(Coleccionable miColec,Iterador IT)
        {
            Console.WriteLine("ELEMENTOS EN LA COLECCION //////////////////////////// \n");
            miColec.queSoy();

            while (! IT.fin())
            {
                Console.WriteLine(IT.actual());
                IT.siguiente();
            }
           
        }

        //revisar para crear una version generica
        public static void cambiarEstrategia(EstrategiaDeComparacion estrategia,Iterador IT)
        {
        
            while (!IT.fin())
            {
                ((Alumno)IT.actual()).setEstrategia(estrategia);
                IT.siguiente();
            }
                          
        }

        //EJERCICIO 13 practica 3

        public static void jornadaDeVenta(Iterador IT)
        {
            GeneradorDeDatosAleatorios x = new GeneradorDeDatosAleatorios();

            while (!IT.fin())
            {
                double monto = x.numeroAleatorio(7000);
                ((Vendedor)IT.actual()).venta(monto);
                IT.siguiente();
            }
                                     
        }


        //PRACTICA 4 ejercicio 4
        public static void ejercicio4()
        {
            Teacher prof = new Teacher();

            for (int i = 0; i < 10; i++)
            {
                IAlumno alumno = (Alumno)FabricaDeComparables.crearAleatorio(1);   
                IAlumno decorador1 = new DecoradorLegajo(alumno);
                IAlumno decorador2 = new DecoradorLetras(decorador1);
                IAlumno decorador3 = new DecoradorPromocion(decorador2);
                IAlumno decorador4 = new DecoradorCuadro(decorador3);
                Student student = new AlumnoAdapter(decorador4); /*???*/
              
                prof.goToClass(student);

               
            }

            for(int i=0; i < 10; i++)
            {
                IAlumno alumno = (AlumMuyEstud)FabricaDeComparables.crearAleatorio(3);
                IAlumno decorador1 = new DecoradorLegajo(alumno);
                IAlumno decorador2 = new DecoradorLetras(decorador1);
                IAlumno decorador3 = new DecoradorPromocion(decorador2);
                IAlumno decorador4 = new DecoradorCuadro(decorador3);
                Student estudioso = new AlumnoAdapter(decorador4); /*???*/

                prof.goToClass(estudioso);
            }

            prof.teachingAClass();

        }

  

    }


}
