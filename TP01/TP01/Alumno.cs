using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Alumno : Persona
    {
        private int legajo;
        private int promedio;
        private EstrategiaDeComparacion estrategia;
        public Alumno(int Dni, string Nombre, int leg, int prom) : base(Nombre, Dni)
        {
            legajo = leg;
            promedio = prom;
            estrategia = new estrategiaLegajo();
        }

        public void setEstrategia(EstrategiaDeComparacion e)
        {
            estrategia = e;
        }

        public int getLegajo()
        {
            return legajo;
        }

        public int getPromedio()
        {
            return promedio;
        }

        public override string ToString()
        {
            return "ALUMNO: " + this.getNombre() + " " + this.getDNI() + " leg: " + legajo + " pro: " + promedio;
        }
        //ejercicio 18
        public override bool sosIgual(Comparable c)
        {
            return estrategia.sosIgual(this, (Alumno)c);
        }
        public override bool sosMenor(Comparable c)
        {
            return estrategia.sosMenor(this, (Alumno)c);
        }
        public override bool sosMayor(Comparable c)
        {
            return estrategia.sosMayor(this, (Alumno)c);
        }
      
    }

    //ESTRATEGIAS DE ALUMNO
    class estrategiaProm : EstrategiaDeComparacion
    {
        //paso 2: implementar subclases, cada subclasee es una estrategia
        public  bool sosIgual(Alumno alum, Alumno alum2)
        {
            return alum.getPromedio() == alum2.getPromedio();
        }
        public bool sosMenor(Alumno alum, Alumno alum2)
        {
            return alum.getPromedio() < alum2.getPromedio();
        }
        public bool sosMayor(Alumno alum, Alumno alum2)
        {
            return alum.getPromedio() > alum2.getPromedio();
        }
    }

    class estrategiaLegajo : EstrategiaDeComparacion
    {
        public bool sosIgual(Alumno alum, Alumno alum2)
        {
            return alum.getLegajo() == alum2.getLegajo();
        }
        public bool sosMenor(Alumno alum, Alumno alum2)
        {
            return alum.getLegajo() < alum2.getLegajo();
        }
        public bool sosMayor(Alumno alum, Alumno alum2)
        {
            return alum.getLegajo() > alum2.getLegajo();
        }
    }

    class estrategiaNomb : EstrategiaDeComparacion
    {
        public bool sosIgual(Alumno alum, Alumno alum2)
        {
            return alum.getNombre() == alum2.getNombre();
        }
        public bool sosMenor(Alumno alum, Alumno alum2)
        {
            return alum.getNombre().Length < alum2.getNombre().Length;
        }
        public bool sosMayor(Alumno alum, Alumno alum2)
        {
            return alum.getNombre().Length > alum2.getNombre().Length;
        }
    }

    class estrategiaDni : EstrategiaDeComparacion
    {
        public bool sosIgual(Alumno alum, Alumno alum2)
        {
            return alum.getDNI() == alum2.getDNI();
        }
        public bool sosMenor(Alumno alum, Alumno alum2)
        {
            return alum.getDNI() < alum2.getDNI();
        }
        public bool sosMayor(Alumno alum, Alumno alum2)
        {
            return alum.getDNI() > alum2.getDNI();
        }
    }
}
