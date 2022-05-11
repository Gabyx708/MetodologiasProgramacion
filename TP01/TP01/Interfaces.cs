using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{

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
        void queSoy();
    }

    //paso 1: interface estrategias
    interface EstrategiaDeComparacion
    {
        bool sosIgual(IAlumno a1, IAlumno a2);
        bool sosMenor(IAlumno a1, IAlumno a2);
        bool sosMayor(IAlumno a1, IAlumno a2);
    }

    interface EstrategiaDeComparacionVend
    {
        bool sosIgual(Vendedor a1, Vendedor a2);
        bool sosMenor(Vendedor a1, Vendedor a2);
        bool sosMayor(Vendedor a1, Vendedor a2);
    }

    //ejercicio 2.6
    interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }

    //aun falta resolver practica 2
    interface Iterable
    {
        Iterador crearIterador();
    }


    //practica 3
    interface IFabricaDeComparables
    {
        Comparable crearAleatorio();
        Comparable crearPorTeclado();
    }


    interface IObservado
    {
        void agregarObservador(IObservador o);
        void quitarObservador(IObservador o);
        void notificar();
    }
    interface IObservador
    {
        void actualizar(IObservado o);
    }

}
