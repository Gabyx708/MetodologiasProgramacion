using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
     class ProxyAlumno : IAlumno ,Comparable
    {
        IAlumno alumnoReal = null;
        private string nombre;
        private int queCrear;

        public ProxyAlumno(string n,int q)
        {
            nombre = n;
            queCrear = q;
        }

        //comportamiento del proxy
        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string n)
        {
            alumnoReal.setNombre(n);
        }

        //metodo complicado
        public int responderPregunta(int pregunta){
            if (alumnoReal == null)
            {
                alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(queCrear);
                IAlumno decorador1 = new DecoradorLegajo(alumnoReal);
                IAlumno decorador2 = new DecoradorLetras(decorador1);
                IAlumno decorador3 = new DecoradorPromocion(decorador2);
                IAlumno decorador4 = new DecoradorCuadro(decorador3);
                alumnoReal = decorador4;
                alumnoReal.setNombre(nombre);
            }
            
            return alumnoReal.responderPregunta(pregunta);
        }

        public bool sosIgual(Comparable c)
        {
            return alumnoReal.sosIgual(c);
        }
        public bool sosMenor(Comparable c)
        {
            return alumnoReal.sosMenor(c);
        }
        public bool sosMayor(Comparable c)
        {
            return alumnoReal.sosMayor(c);
        }
        public void setCalificacion(int uc)
        {
            alumnoReal.setCalificacion(uc);  
        }
        public string mostrarCalificacion()
        {
            return alumnoReal.mostrarCalificacion();
        }

        public int getCalificacion()
        {
            return alumnoReal.getCalificacion();
        }
        public int getLegajo()
        {
            return alumnoReal.getLegajo();
        }
        public int getDNI()
        {
            return alumnoReal.getDNI();
        }
        public int getPromedio()
        {
            return alumnoReal.getPromedio();
        }
        public EstrategiaDeComparacion getEstrategia(){
            return alumnoReal.getEstrategia();
        }
        public void setEstrategia(EstrategiaDeComparacion e)
        {
            alumnoReal.setEstrategia(e);
        }
    }
}
