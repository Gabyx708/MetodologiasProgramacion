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
           
            string[] nombres = new string[6] { "Gaby", "Maria", "Luigi", "Daisy", "Pedro", "Lucia" };
            int posi = R.numeroAleatorio(6);

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

            string[] nombres = new string[2] { "Manuel", "Brisa"};
            int posi = R.numeroAleatorio(2);

            string nomR = nombres[posi];
            int dniR = R.numeroAleatorio(1000);
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
  

}
