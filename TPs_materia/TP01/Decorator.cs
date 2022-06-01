using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    //DECORATOR 
    //1.crear la interfaz componente
    public interface IAlumno
    {
        bool sosIgual(Comparable c);
        bool sosMenor(Comparable c);
        bool sosMayor(Comparable c);
        void setCalificacion(int uc);
        int responderPregunta(int i);
        string mostrarCalificacion();
        string getNombre();

        int getCalificacion();
        int getLegajo();
        int getDNI();
        int getPromedio();
        void setNombre(string n);
        EstrategiaDeComparacion getEstrategia();
        void setEstrategia(EstrategiaDeComparacion e);
    }
    abstract class DecoradorAlumno: IAlumno , Comparable{

        private IAlumno adicional;
        public DecoradorAlumno(IAlumno a)
        {
            adicional = a;
        }

     
        //metodos del alumno
        public EstrategiaDeComparacion getEstrategia()
        {
            return adicional.getEstrategia();
        }

        public void setNombre(string n)
        {
            adicional.setNombre(n);
        }

        public int getCalificacion()
        {
            return adicional.getCalificacion();
        }

        public void setEstrategia(EstrategiaDeComparacion e)
        {
            adicional.setEstrategia(e);
        }
        public int getPromedio()
        {
            return adicional.getPromedio();
        }
        public int getLegajo()
        {
            return adicional.getLegajo();
        }
        public int getDNI()
        {
            return adicional.getDNI();
        }
        public bool sosIgual(Comparable c)
        {
            return adicional.sosIgual(c);
        }
        public bool sosMenor(Comparable c)
        {
            return adicional.sosMenor(c);
        }
        public bool sosMayor(Comparable c)
        {
            return adicional.sosMayor(c);
        }
        public void setCalificacion(int uc)
        {
            adicional.setCalificacion(uc);
        }
        public int responderPregunta(int i)
        {
            return adicional.responderPregunta(i);
        }
        public string getNombre()
        {
            return adicional.getNombre();
        }
        public virtual string mostrarCalificacion()
        {
            return adicional.mostrarCalificacion();
        }
        public override string ToString()
        {
            return adicional.ToString();
        }
    }

    //crear decoradores concretos
   class DecoradorLegajo : DecoradorAlumno
    {
        public DecoradorLegajo(IAlumno al) : base(al)
        {
            
        }

        public override string mostrarCalificacion()
        {
            string resultado = base.mostrarCalificacion();
            return resultado +" "+base.getLegajo();
        }
    }

    class DecoradorLetras : DecoradorAlumno
    {
        public DecoradorLetras(IAlumno a): base(a)
        {
            
        }

        public override string mostrarCalificacion()
        {
            string resultado = base.mostrarCalificacion();
            string [] letras = new string []{"CERO","UNO","DOS","TRES","CUATRO","CINCO","SEIS","SIETE","OCHO","NUEVO","DIEZ" };
            resultado +=" "+letras[base.getCalificacion()];

            return resultado;
        }
       
    }

    class DecoradorPromocion : DecoradorAlumno
    {
        public DecoradorPromocion(IAlumno a): base(a)
        {

        }

        public override string mostrarCalificacion()
        {
            int nota = base.getCalificacion();
            string resultado = "";

            if(nota > 7)
            {
                resultado = " PROMOCION ";
            }

            if (nota <= 7)
            {
                resultado = " APROBADO ";
            }

            if(nota < 4)
            {
                resultado = " DESAPROBADO ";
            }

            return base.mostrarCalificacion()+resultado;

        }
    }

    class DecoradorCuadro : DecoradorLegajo
    {
        public DecoradorCuadro(IAlumno a) : base(a)
        {

        }
        public override string mostrarCalificacion()
        {
            string resultado = "*****************************\n"+" * "+base.mostrarCalificacion()+" * "+"\n*****************************\n";
            return resultado;
        }
    }
    
    
}
