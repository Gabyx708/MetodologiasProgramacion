using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{

    //esta es la gran fabrica ,es capaz de fabricar cualquier comparable
     abstract class FabricaDeComparables : IFabricaDeComparables
    {
        public static Comparable crearAleatorio(int producto)
        {
            FabricaDeComparables fabrica = null;

            switch (producto)
            {
                case 0: fabrica = new FabricaDeNumeros(); break;
                case 1: fabrica = new FabricaDeAlumnos(); break;
                case 2: fabrica = new FabricaDeVendedores(); break;
                case 3: fabrica = new FabricaDeAlumEstudiosos(); break;
                case 4: fabrica = new FabricaDeCompuestoDecorado(); break;
            }

            return  fabrica.crearAleatorio();
        }

        public static Comparable crearPorTeclado(int producto)
        {
            FabricaDeComparables fabrica = null;

            switch (producto)
            {
                case 0: fabrica = new FabricaDeNumeros(); break;
                case 1: fabrica = new FabricaDeAlumnos(); break;
                case 2: fabrica = new FabricaDeVendedores(); break;
                case 3: fabrica = new FabricaDeAlumEstudiosos(); break;
                
            }

            return fabrica.crearPorTeclado();
        }

        abstract public Comparable crearAleatorio();

        abstract public Comparable crearPorTeclado();
        
    }

    //en realidad lo que hace es pedirle a sus fabricas "hijas" que elaboren el producto

     class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios x = new GeneradorDeDatosAleatorios();
            int Nrandom = x.numeroAleatorio(100);
            return new Numero(Nrandom);
        }

        public override Comparable crearPorTeclado()
        {
            Console.WriteLine("ingresa un numero: ");
            int x = int.Parse(Console.ReadLine());
            Numero f= new Numero(x);
            return f;
        }
    }

    class FabricaDeAlumnos : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
          
            GeneradorDeDatosAleatorios R = new GeneradorDeDatosAleatorios();
           
            string[] nombres = new string[8] { "Gaby", "Maria", "Luigi", "Daisy", "Pedro", "Lucia","Enrique","Camila" };
            int posi = R.numeroAleatorio(8);

            string nomR = nombres[posi];
            int dniR = R.numeroAleatorio(1000);
            int legR = R.numeroAleatorio(500);
            int promR = R.numeroAleatorio(10);

            Alumno AlumRand = new Alumno(dniR,nomR,legR,promR);

            return AlumRand;
        }

        public override Comparable crearPorTeclado()
        {
            Console.Write("ingresa el nombre completo:");
            string n = Console.ReadLine();
            Console.Write("ingresa el promedio:");
            int p = int.Parse(Console.ReadLine());
            Console.Write("ingresa el legajo:");
            int L = int.Parse(Console.ReadLine());
            Console.Write("ingresa el DNI:");
            int D = int.Parse(Console.ReadLine());

            Alumno nuev = new Alumno(D,n,L,p);
            return nuev;
        }
    }

    class FabricaDeAlumEstudiosos : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios R = new GeneradorDeDatosAleatorios();

            string[] nombres = new string[3] { "Manuel", "Camila","Brisa"};
            int posi = R.numeroAleatorio(3);

            string nomR = nombres[posi];
            int dniR = R.numeroAleatorio(10000);
            int legR = R.numeroAleatorio(500);
            int promR = R.numeroAleatorio(10);

            AlumMuyEstud AlumRand = new AlumMuyEstud(dniR, nomR, legR, promR);

            return AlumRand;
        }

        public override Comparable crearPorTeclado()
        {
            return null;
        }
    }

    class FabricaDeVendedores : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios x = new GeneradorDeDatosAleatorios();

            int dni = x.numeroAleatorio(100);
            int suel = x.numeroAleatorio(5000);
            int bonu = x.numeroAleatorio(5);
            string nom = x.stringAleaotrio(10);
            Vendedor rand = new Vendedor(dni,nom,suel);
            rand.setBonus(bonu);
            return rand;
        }

        public override Comparable crearPorTeclado()
        {
            Console.Write("ingresa el nombre del vendedor:");
            string n = Console.ReadLine();
            Console.Write("ingresa el sueldo:");
            int S = int.Parse(Console.ReadLine());
            Console.Write("ingresa el DNI:");
            int D = int.Parse(Console.ReadLine());

            Vendedor vend = new Vendedor(D,n,S);
            return vend;
        }
    }

    class FabricaDeCompuestoDecorado : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            AlumnoCompuesto compuesto = new AlumnoCompuesto();
            
            for (int j=0;j<3;j++)
            {
                AlumnoCompuesto compuesto2 = new AlumnoCompuesto();

                for(int i = 0; i < 5; i++)
                {
                    FabricaDeAlumnos af = new FabricaDeAlumnos();
                    IAlumno aleatorios = (IAlumno)af.crearAleatorio();
                    IAlumno decorador1 = new DecoradorLegajo(aleatorios);
                    IAlumno decorador2 = new DecoradorLetras(decorador1);
                    IAlumno decorador3 = new DecoradorPromocion(decorador2);
                    IAlumno decorador4 = new DecoradorCuadro(decorador3);
                    compuesto2.agregar(decorador4);
                }

                compuesto.agregar(compuesto2);
            }


            return compuesto;
        }

        public override Comparable crearPorTeclado()
        {
            return null;
        }
    }
  

}
