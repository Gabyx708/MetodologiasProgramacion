using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Alumno : Persona , IAlumno
    {
        private int legajo;
        private int promedio;
        private int calificacion;
        private EstrategiaDeComparacion estrategia;
        public Alumno(int Dni, string Nombre, int leg, int prom) : base(Nombre, Dni)
        {
            legajo = leg;
            promedio = prom;
            estrategia = new estrategiaLegajo();
            calificacion = 0;
        }

        public void setEstrategia(EstrategiaDeComparacion e)
        {
            estrategia = e;
        }

        public EstrategiaDeComparacion getEstrategia()
        {
            return estrategia;
        }

        public void setCalificacion(int c)
        {
            calificacion = c;
        }

        public int getCalificacion()  
        {
            return calificacion;
        }
           
        public int getLegajo()
        {
            return legajo;
        }

   
        public int getPromedio()
        {
            return promedio;
        }

        public virtual int responderPregunta(int pregunta)
        {
            GeneradorDeDatosAleatorios x = new GeneradorDeDatosAleatorios();
            int n = x.numeroAleatorio(3);

            if(n == 0)
            {
                n = 1;
            }

            return n;
        }

        public string mostrarCalificacion() //comportamiento base
        {
            return this.getNombre() +" "+ calificacion;
        }

        public override string ToString()
        {
            return "ALUMNO: " + this.getNombre() + " " + this.getDNI() + " leg: " + legajo + " pro: " + promedio;
        }
        //ejercicio 18
        //metodos para comparar a un alumno
        public override bool sosIgual(Comparable c)
        {
            return estrategia.sosIgual(this, (IAlumno)c);
        }
        public override bool sosMenor(Comparable c)
        {
            return estrategia.sosMenor(this, (IAlumno)c);
        }
        public override bool sosMayor(Comparable c)
        {
            return estrategia.sosMayor(this, (IAlumno)c);
        }
      
    }

    //ESTRATEGIAS DE ALUMNO
    class estrategiaProm : EstrategiaDeComparacion
    {
        //paso 2: implementar subclases, cada subclasee es una estrategia
        public  bool sosIgual(IAlumno alum, IAlumno alum2)
        {
            return alum.getPromedio() == alum2.getPromedio();
        }
        public bool sosMenor(IAlumno alum, IAlumno alum2)
        {
            return alum.getPromedio() < alum2.getPromedio();
        }
        public bool sosMayor(IAlumno alum, IAlumno alum2)
        {
            return alum.getPromedio() > alum2.getPromedio();
        }
    }

    class estrategiaLegajo : EstrategiaDeComparacion
    {
        public bool sosIgual(IAlumno alum, IAlumno alum2)
        {
            return alum.getLegajo() == alum2.getLegajo();
        }
        public bool sosMenor(IAlumno alum, IAlumno alum2)
        {
            return alum.getLegajo() < alum2.getLegajo();
        }
        public bool sosMayor(IAlumno alum, IAlumno alum2)
        {
            return alum.getLegajo() > alum2.getLegajo();
        }
    }

    class estrategiaNomb : EstrategiaDeComparacion
    {
        public bool sosIgual(IAlumno alum, IAlumno alum2)
        {
            if(alum.getNombre().CompareTo(alum2.getNombre()) == 0)
            {
                return true;
            }
                return false;
        }
        public bool sosMenor(IAlumno alum, IAlumno alum2)
        {
            return alum.getNombre().Length < alum2.getNombre().Length;
        }
        public bool sosMayor(IAlumno alum, IAlumno alum2)
        {
            return alum.getNombre().Length > alum2.getNombre().Length;
        }
    }

    class estrategiaDni : EstrategiaDeComparacion
    {
        public bool sosIgual(IAlumno alum, IAlumno alum2)
        {
            return alum.getDNI() == alum2.getDNI();
        }
        public bool sosMenor(IAlumno alum, IAlumno alum2)
        {
            return alum.getDNI() < alum2.getDNI();
        }
        public bool sosMayor(IAlumno alum, IAlumno alum2)
        {
            return alum.getDNI() > alum2.getDNI();
        }
    }
}
