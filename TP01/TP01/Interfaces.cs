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
    }

    //paso 1: interface estrategias
    interface EstrategiaDeComparacion
    {
        bool sosIgual(Alumno a1, Alumno a2);
        bool sosMenor(Alumno a1, Alumno a2);
        bool sosMayor(Alumno a1, Alumno a2);
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
}
