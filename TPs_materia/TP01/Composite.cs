using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
     class AlumnoCompuesto : IAlumno , Comparable
    {
        private List<IAlumno> hijos = new List<IAlumno>();

        public void agregar(IAlumno a)
        {
            hijos.Add(a);
        }

        public override string ToString()
        {
            string alumnosC = "";
            foreach (var x in hijos)
               alumnosC+=" // \n"+x.ToString();

            return alumnosC;
        }
        //implementar interfaz Ialumno

        public string getNombre()
        {
            string nombre = "";

            foreach (IAlumno a in hijos)
                nombre += a.getNombre();
            return nombre;
        }

        public int responderPregunta(int i)
        {
            int con1=0, con2=0, con3=0,mayor=-1;

            foreach (IAlumno a in hijos){

                if (a.responderPregunta(i) == 1)
                        con1++;
                if (a.responderPregunta(i) == 2)
                        con2++;
                if (a.responderPregunta(i) == 3)
                        con3++;
            }

            if (con1 < con2 && con1 < con3)
                         mayor = con1;

            if (con2 < con3 && con2< con1)
                    mayor = con2;

            if (con3 < con2 && con3 < con1)
                    mayor = con3;

            return mayor;   
        }

        public void setCalificacion(int uc)
        {
            foreach (IAlumno a in hijos)
                a.setCalificacion(uc);
        }

        public bool sosIgual(Comparable h)
        {
            foreach (IAlumno a in hijos)
            {
                if (a.sosIgual(h))
                {
                    return true;
                }
            }
            return false;
        }

        public bool sosMenor(Comparable h)
        {
            int cont = 0;
            foreach(IAlumno a in hijos)
            {
                if (a.sosMenor(h))
                {
                    cont++;
                }
            }
           
            if(cont == hijos.Count)
            {
                return true;
            }

            return false;
        }

        public bool sosMayor(Comparable h)
        {
            int cont = 0;
            foreach (IAlumno a in hijos)
            {
                if (a.sosMayor(h))
                {
                    cont++;
                }
            }

            if (cont == hijos.Count)
            {
                return true;
            }

            return false;
        }

        //
        public string mostrarCalificacion()
        {
            string calificaciones = " ";
            foreach (IAlumno a in hijos)
               calificaciones+= a.mostrarCalificacion();
            return calificaciones;
        }

        public int getCalificacion()
        {
            int cali = 0;
            foreach (IAlumno a in hijos)
                cali += a.getCalificacion();
            return cali;
        }
        public int getLegajo()
        {
            int leg = 0;
            foreach (IAlumno a in hijos)
                leg += a.getLegajo();
            return leg;
        }
        public int getDNI()
        {
            int dni = 0;
            foreach (IAlumno a in hijos)
                dni += a.getDNI();
            return dni;
        }
        public int getPromedio()
        {
            int prom = 0,cont=0;
            foreach (IAlumno a in hijos)
            {
                prom += a.getPromedio();
                cont++;
            }
            return prom / cont; //devuelve un promedio general de TODOS los alumnos 
        }
        public void setNombre(string n)
        {
            foreach (IAlumno a in hijos)
                        a.setNombre(n);
        }
        public EstrategiaDeComparacion getEstrategia()
        {
            foreach (IAlumno a in hijos)
                Console.WriteLine(a.getEstrategia());
            return null;
        }
        public void setEstrategia(EstrategiaDeComparacion e)
        {
            foreach (IAlumno a in hijos)
                a.setEstrategia(e);
        }
    }
}
