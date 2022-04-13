using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Conjunto
    {
        private List<Comparable> elementos;

        public Conjunto()
        {
            elementos = new List<Comparable>();
        }

        public List<Comparable> getElemetos()
        {
            return elementos;
        }
        public void agregar(Comparable c)
        {
            foreach (var comparable in elementos)
            {
                if (!c.sosIgual(comparable))
                {
                    elementos.Add(c);
                }
            }
        }

        public bool pertenece(Comparable c)
        {
            return false;
        }
    }
}
