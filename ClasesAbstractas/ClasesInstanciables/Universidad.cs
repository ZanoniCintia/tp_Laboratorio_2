using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace ClasesInstanciables
{
    public class Universidad
    {
        #region Campos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region Propiedades

        public List<Alumno> Alumnos
        {
            get { return alumnos; }
            set { alumnos = value; }
        }
        public List<Profesor> Instructores
        {
            get { return profesores; }
            set { profesores = value; }
        }
        public List<Jornada> Jornadas
        {
            get { return jornada; }
            set { jornada = value; }
        }

        public Jornada this[int i]
        {
            get { return jornada[i]; }
            set { jornada[i] = value; }
        }


        #endregion

        #region Metodos
        public Universidad()
        {
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
            this.alumnos = new List<Alumno>();
        }

        public static bool operator ==(Universidad g ,Alumno a)
        {
            bool retorno = false;
            foreach (Alumno auxAlumno in g.alumnos)
            {
                if (auxAlumno == a)
                {
                    retorno= true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Universidad g , Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Universidad g , Profesor i)
        {
            bool retorno = false;
            foreach (Profesor auxProf in g.profesores)
            {
                if (auxProf == i)
                {
                    retorno = true;
                }
                
            }
            return retorno;
        }

        public static bool operator !=(Universidad g , Profesor i)
        {
            return !(g == i);
        }

        public static Profesor operator ==(Universidad u, EClases clase)
        {
            Profesor retorno = null;
            foreach (Profesor auxProf in u.profesores)
            {
                if (auxProf == clase)
                {
                    retorno = auxProf;
                }                     
            }  
            if (retorno is null)
            {
                throw new SinProfesorException();
            }
            return retorno;
        }
        public static Universidad operator +(Universidad u, Alumno a)
        {
            foreach (Alumno auxAlum in u.alumnos)
            {
                if (auxAlum == a)
                {
                    throw new AlumnoRepetidoException();
                }
            }
            u.alumnos.Add(a);
            return u;
        }
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor profesor = new Profesor();
            profesor = (g == clase);
            Jornada nuevaJornada = new Jornada(clase, profesor);
            foreach (Alumno item in g.alumnos)
            {
                if (item == clase)
                {
                    nuevaJornada.Alumnos.Add(item);
                }
            }
            g.jornada.Add(nuevaJornada);
            return g;
        }
        public static Universidad operator +(Universidad u, Profesor i)
        {
            foreach (Profesor auxProf in u.profesores)
            {
                if (auxProf == i)
                {
                    return u;
                }
            }
            u.profesores.Add(i);
            return u;
        }

        public static Profesor operator !=(Universidad u , EClases clase)
        {
            Profesor retorno =null;
            foreach (Profesor auxProf in u.profesores)
            {
                if (auxProf != clase)
                {
                     retorno=auxProf;
                }
            }
            return retorno;
        }

        public static bool Guardar(Universidad uni)
        {

            Xml<Universidad> xml = new Xml<Universidad>();
            return xml.Guardar("Universidad.xml", uni);
        }
        public Universidad Leer()
        {

            Xml<Universidad> xml = new Xml<Universidad>();
            Universidad universidad = new Universidad();
            xml.Leer("Universidad.xml", out universidad);
            return universidad;
        }

        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("JORNADA :");
            foreach(Jornada aux in uni.jornada)
            {
                sb.Append(aux.ToString());
                sb.AppendLine("<---------------------------------------------------->\n");
            }
            return sb.ToString();

        }

        public override string ToString()
        {
            return MostrarDatos(this);
        }

      
        #endregion
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            Spd
        }
    }
}
