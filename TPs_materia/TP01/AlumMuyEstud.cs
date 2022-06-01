using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class AlumMuyEstud : Alumno
    {
        public AlumMuyEstud(int d,string n,int l,int p):base(d,n,l,p)
        {

        }

        public override int responderPregunta(int pregunta)
        {
            return pregunta%3;
        }


    }
}
