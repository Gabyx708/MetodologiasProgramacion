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
            if (!pertenece(c))     
                elementos.Add(c);
               
        }

        public bool pertenece(Comparable c)
        {
            foreach (var ele in elementos)
            {
                if (ele.Equals(c))
                {
                    return true;
                }
            }

            return false;
        }

        public void muestrame()
        {
            foreach (var ele in elementos)
                Console.WriteLine(ele.ToString());
        }
    }
}
