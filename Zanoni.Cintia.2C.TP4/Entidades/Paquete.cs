using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Paquete:IMostrar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { direccionEntrega = value; }
        }

        public EEstado Estado
        {
            get { return this.estado; }
            set { estado = value; }
        }

        public string TrackinID
        {
            get { return this.trackingID; }
            set { trackingID = value; }
        }

        public void MockCicloDeVida()
        {
            int auxEstado = (int)this.estado;
            if(auxEstado != 2)
            {
                
                Thread.Sleep(4000);
                auxEstado++;
            }
        }

        public string MostrarDatos(IMostrar<Paquete>elemento)
        {
            string s="";
            if(elemento is Paquete)
            {
                Paquete p = new Paquete();
                s= string.Format("{0} Para {1}", p.trackingID,p.DireccionEntrega);
                
            }
            return s;//ver si anda
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}",this.MostrarDatos(this));
            sb.AppendFormat("{0}", this.estado);
            return sb.ToString();
        }

        public static bool operator ==(Paquete p1,Paquete p2)
        {
            bool retorno = false;
            if(p1.trackingID == p2.trackingID)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Paquete p1,Paquete p2)
        {
            return !(p1 == p2);
        }












        public event DelegadoEstado InformaEstado;
        public delegate void DelegadoEstado();
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
      
}
