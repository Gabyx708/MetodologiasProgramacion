using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;

namespace TP01
{
    class AlumnoAdapter : Student
    {
        IAlumno alumno;

        public AlumnoAdapter(IAlumno a)
        {
            alumno = a;
        }

        public IAlumno getAlum()
        {
            return alumno;
        }

        public string getName()
        {
            return alumno.getNombre();
        }

        public int yourAnswerIs(int question)
        {
            return alumno.responderPregunta(question);
        }
        public void setScore(int score)
        {
             alumno.setCalificacion(score);
        }
        public string showResult()
        {
            return alumno.mostrarCalificacion();
        }
        public  bool equals(Student student)
        {
            return alumno.sosIgual((Comparable)((AlumnoAdapter)student).getAlum());
        }
        public bool lessThan(Student student)
        {
            return alumno.sosMenor((Comparable)((AlumnoAdapter)student).getAlum());
        }
        public bool greaterThan(Student student)
        {
            return alumno.sosMayor((Comparable)((AlumnoAdapter)student).getAlum());
        }
    }
}
