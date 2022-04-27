using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class GeneradorDeDatosAleatorios 
    {
        public int numeroAleatorio(int max)
        {
            Random num = new Random();
            int numero = num.Next(0,max);

            return numero;
        }

        public string stringAleaotrio(int cant)
        {
            string miTexto = "";
            Random text = new Random();

            for (int i=0;i<cant;i++)
            {
                char letra = (char)text.Next('a','z');

                miTexto += letra;
            }
            return miTexto;
        }
    }


    class lectoDeDatos
    {
        public int numeroPorTeclado()
        {
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }
    }
}
