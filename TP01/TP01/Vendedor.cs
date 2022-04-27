using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Vendedor : Persona , IObservado
    {
        int sueldoBasico;
        double bonus;
        private EstrategiaDeComparacionVend estrategia;

        public Vendedor(int Dni,string Nombre,int s):base(Nombre,Dni)
        {
            sueldoBasico = s;
            bonus = 0;
            estrategia = new EstrategiaBonus();
        }

        public void venta(double monto)
        {
            Console.WriteLine("esta venta es de: "+monto);
            this.notificar();
   
        }

        public void aumentaBonus()
        {
            bonus = bonus + 0.1;
        }

        public double getBonus()
        {
            return bonus;
        }

        public void setBonus(int c)
        {
            bonus = c;
        }

        public override string ToString()
        {
            return "Nombre Vendedor: " + this.getNombre() + " sueldo: " + sueldoBasico + "bonus: "+ this.getBonus();
        }

        //metodos para comparar a un vendedor
        public override bool sosIgual(Comparable c)
        {
            return estrategia.sosIgual(this,(Vendedor)c);
        }
        public override bool sosMenor(Comparable c)
        {
            return estrategia.sosMenor(this, (Vendedor)c);
        }
        public override bool sosMayor(Comparable c)
        {
            return estrategia.sosMayor(this, (Vendedor)c);
        }

        //observer
        List<IObservador> observadores = new List<IObservador>();

        public void agregarObservador(IObservador o)
        {
            observadores.Add(o);
        }

        public void quitarObservador(IObservador o)
        {
            observadores.Remove(o);
        }

        public void notificar()
        {
            foreach (IObservador o in observadores)
                        o.actualizar(this);
        }
    }

    //ESTRATEGIAS DEL VENDEDOR

    class EstrategiaBonus : EstrategiaDeComparacionVend
    {
        public bool sosIgual(Vendedor v1, Vendedor v2)
        {
            return v1.getBonus() == v2.getBonus();
        }
        public bool sosMenor(Vendedor v1, Vendedor v2)
        {
            return v1.getBonus() < v2.getBonus();
        }
        public bool sosMayor(Vendedor v1, Vendedor v2)
        {
            return v1.getBonus() > v2.getBonus();
        }
    }
}
