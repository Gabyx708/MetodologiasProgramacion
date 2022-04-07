using System;
using System.Collections.Generic;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTERFACEEEEES :D \n");

            /*Comparable c1, c2;

            c1 = new Numero(10);
            c2 = new Numero(10);

            Console.WriteLine(c1.sosIgual(c2));*/
            

            Pila test = new Pila();
            Cola test2 = new Cola();

            //ejercicio 5
            static void llenar(Coleccionable miCole)
            {
                Random numb = new Random();
 
                for (int i=0;i<20;i++)
                {
                    Comparable ele = new Numero(numb.Next(10,50));
                    miCole.agregar(ele);
                }

            }

            //ejercicio 6
            static void informar(Coleccionable miCole)
            {
                Console.WriteLine(miCole.cuantos());
                Console.WriteLine(miCole.minimo());
                Console.WriteLine(miCole.maximo());

                int ing = (int.Parse(Console.ReadLine()));
                Comparable valor = new Numero(ing);

                if (miCole.contiene(valor))
                {
                    Console.WriteLine("si esta");
                }
                else
                {
                    Console.WriteLine("No esta");
                }
            }

            //EJERCICIO 7
            llenar(test);
            llenar(test2);
            /*informar(test);*/
            Console.WriteLine("LA PILA ESTA ABAJO: ---------------------->");
           /* informar(test2);*/

            ColeccionMultiple Multiple = new ColeccionMultiple(test,test2);

            int ing = (int.Parse(Console.ReadLine()));
            Comparable valor = new Numero(ing);
            Console.WriteLine(Multiple.contiene(valor));

            //EJERCICIO 9
            /*informar(Multiple);*/

            //EJERCICIO 12
            static void llenarPersonas(Coleccionable laColec)
            {
                Random dni = new Random();
                Random name = new Random();

                int dniAzar = dni.Next(300,500);
                string[] nombres = new string[4] {"Gaby","Maria","Luigi","Daisy" };
                int posi = name.Next(0, 3);

                string nomAzar = nombres[posi];

                for (int i= 0;i<20;i++)
                {
                    Comparable unTipoRandom = new Persona(nomAzar, dniAzar);
                    laColec.agregar(unTipoRandom);
                }
            }

            //EJERCICIO 13
            Pila Pila = new Pila();
            Cola Cola = new Cola();
            Multiple = new ColeccionMultiple(Pila, Cola);

            llenarPersonas(Pila);
            llenarPersonas(Cola);

            /*informar(Multiple);*/

            //EJERCICIO 16

            static void llenaAlumnos(Coleccionable c)
            {
                for (int i=0;i<20;i++)
                {
                    Random dni = new Random();
                    Random name = new Random();
                    Random leg = new Random();
                    Random prom = new Random();

                    
                    string[] nombres = new string[6] { "Gaby", "Maria", "Luigi", "Daisy","Pedro","Lucia" };
                    int posi = name.Next(0, 5);

                    string nomR = nombres[posi];
                    int dniR = dni.Next(300, 500);
                    int legR = leg.Next(5000,6000);
                    int promR = prom.Next(1,10);

                    Comparable alumRandom = new Alumno(dniR,nomR,legR,promR);

                    c.agregar(alumRandom);
                }

            }

            //EJERCICIO 17
            Pila = new Pila();
            Cola = new Cola();

            Multiple = new ColeccionMultiple(Pila,Cola);
            llenaAlumnos(Pila);
            llenaAlumnos(Cola);
            informar(Multiple);

        } //fin del main
           




        //INTERFACES
        //ejercicio 1
           interface Comparable
        {
            bool sosIgual(Comparable c);
            bool sosMenor(Comparable c);
            bool sosMayor(Comparable c);
        }

        //ejercicio 3
        interface Coleccionable
        {
            int cuantos();
            Comparable minimo();
            Comparable maximo();
            void agregar(Comparable c);
            bool contiene(Comparable c);
        }


        //CLASES
        //ejercicio 2

        class Numero: Comparable
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

        //ejercicio 4

        class Pila : Coleccionable
        {
            private List<Comparable> elementos;

            public Pila()
            {
                elementos = new List<Comparable>();
            }

            public void push(Comparable c)
            {
                elementos.Add(c);
            }

            public Comparable pop()
            {
                Comparable e = elementos[elementos.Count - 1];
                elementos.RemoveAt(elementos.Count - 1);
                return e;
            }

            //implementar interfaz

            public int cuantos()
            {
                return this.elementos.Count;
            }

            public Comparable minimo()
            {
                Comparable masChico = elementos[0];

                for (int i=1; i< this.cuantos();i++)
                {
                    if (elementos[i].sosMenor(masChico))
                    {
                        masChico = elementos[i];
                    }
                }

                return masChico;
            }

            public Comparable maximo()
            {
                Comparable masGrande = elementos[0];

                for (int i = 1; i < this.cuantos(); i++)
                {
                    if (elementos[i].sosMayor(masGrande))
                    {
                        masGrande = elementos[i];
                    }
                }

                return masGrande;
            }


            public void agregar(Comparable c)
            {
                elementos.Add(c);
            }

            public bool contiene(Comparable c)
            {

                for (int i =0;i<this.cuantos();i++)
                {
                    if (elementos[i].sosIgual(c))
                    {
                        return true;
                    }
                }

                return false;
            }

        }


        //la COLA

        class Cola: Coleccionable
        {
            private List<Comparable> elementos;

            public Cola()
            {
                elementos = new List<Comparable>();
            }

            public void agregar(Comparable c)
            {
                elementos.Add(c);
            }

            public int cuantos()
            {
                return this.elementos.Count;
            }

            public Comparable minimo()
            {
                Comparable masChico = elementos[0];

                for (int i = 1; i < this.cuantos(); i++)
                {
                    if (elementos[i].sosMenor(masChico))
                    {
                        masChico = elementos[i];
                    }
                }

                return masChico;
            }

            public Comparable maximo()
            {
                Comparable masGrande = elementos[0];

                for (int i = 1; i < this.cuantos(); i++)
                {
                    if (elementos[i].sosMayor(masGrande))
                    {
                        masGrande = elementos[i];
                    }
                }

                return masGrande;
            }


            public bool contiene(Comparable c)
            {

                for (int i = 0; i < this.cuantos(); i++)
                {
                    if (elementos[i].sosIgual(c))
                    {
                        return true;
                    }
                }

                return false;
            }

            public Comparable desencolar()
            {
                Comparable e = elementos[0];
                elementos.RemoveAt(0);
                return e;
            }

        }

        //EJERCICIO 8
        class ColeccionMultiple : Coleccionable
        {
            Pila miPila;
            Cola miCola;

            public ColeccionMultiple(Pila P ,Cola C)
            {
                miPila = P;
                miCola = C;
            }

            public int cuantos()
            {
               int total = miPila.cuantos() + miCola.cuantos();
                return total;
            }

            public Comparable minimo()
            {
                if (miPila.minimo().sosMenor(miCola.minimo())){
                    return miPila.minimo();
                }

                return miCola.minimo();
            }

            public Comparable maximo()
            {
                if (miPila.maximo().sosMayor(miCola.maximo())){
                    return miPila.maximo();
                }

                return miCola.maximo();
            }

            public bool contiene(Comparable c)
            {
                if (miCola.contiene(c) || miPila.contiene(c) )
                {
                    return true;
                }

                return false;
            }
            public void agregar(Comparable c)
            {
                Console.WriteLine("zzz");
            }
        }


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

            public string getNombre()
            {
                return nombre;
            }

            public override string ToString()
            {
                return getNombre() + " ----- " + getDNI();
            }

            //interfaz

            public bool sosIgual(Comparable c)
            {
                return this.dni == ((Persona)c).getDNI();
            }
            public bool sosMenor(Comparable c)
            {
                return this.dni < ((Persona)c).getDNI();
            }
            public bool sosMayor(Comparable c)
            {
                return this.dni > ((Persona)c).getDNI();
            }
        }


        //EJERCICIO 15 

        class Alumno : Persona
        {
            private int legajo;
            private int promedio;

            public Alumno(int Dni,string Nombre,int leg,int prom):base(Nombre,Dni)
            {
                legajo = leg;
                promedio = prom;
            }

            public int getLegajo()
            {
                return legajo;
            }

            public int getPromedio()
            {
                return promedio;
            }
        }
    }
}
