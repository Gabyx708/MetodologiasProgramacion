using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;

namespace TP01
{   
    interface IOrdenAula1{
        void ejecutar();
    }

    interface IOrdenAula2{
        void ejecutar(Comparable c);
    }

    interface IOrdenable{
        void setOrdenInicio(IOrdenAula1 a);
        void setOrdenLlegaAlumno(IOrdenAula2 a2);
        void setOrdenAulaLLena(IOrdenAula1 a1);
    }
    public class Aula
    {
        private Teacher teacher;

        public Aula()
        {
           
        }

        public void comenzar()
        {
            teacher = new Teacher();
            Console.WriteLine("despertando....");
        }

        public void nuevoAlumno(IAlumno a)
        {
            teacher.goToClass(new AlumnoAdapter(a));
        }

        public void claseLista()
        {
            teacher.teachingAClass();
        }
    }

    public class OrdenInicio : IOrdenAula1
    {
        private Aula aula;

        public OrdenInicio(Aula a)
        {
            aula = a;
        }

        public void ejecutar()
        {
            aula.comenzar();
        }

    }

    public class OrdenAulaLlena : IOrdenAula1
    {
        private Aula aula;

        public OrdenAulaLlena(Aula a)
        {
            aula = a;
        }

        public void ejecutar()
        {
            aula.claseLista();
        }
    }

    public class OrdenLlegaAlumno : IOrdenAula2
    {
        private Aula aula;

        public OrdenLlegaAlumno(Aula a)
        {
            aula = a;
        }

        public void ejecutar(Comparable c)
        {
            aula.nuevoAlumno((IAlumno)c);
        }
    }
}
