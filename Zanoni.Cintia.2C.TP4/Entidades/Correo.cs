using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo:IMostrar<List<Paquete>>
    {
        public List<Thread> mockPaquetes;
        public List<Paquete> paquetes;
        
        public List<Paquete>Paquetes
        {
            get { return  this.paquetes; }
            set {  paquetes= value; }
        }

        public Correo()
        {
            
           
        }

        public void FinEntregas()
        {

        }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            string s = "";
            
            if(elementos is List<Paquete>)
            {
                
                s = string.Format("{0}",elementos.ToString());
                
            }
            return s;
        }

        public static Correo operator +(Correo c,Paquete p)
        {
            foreach(Paquete pAux in c.paquetes)
            {   

                if(pAux != p)
                {
                    c.paquetes.Add(p);
                    Thread hilo = new Thread(p.MockCicloDeVida);
                    c.mockPaquetes.Add(hilo);

                    hilo.Start();
                    return c;
                }
                else { throw new TrackingIdRepetidoException(""); }

                
            }
            return c;
        }

        public void FinDeEntregas()
        {
            foreach(Thread t in mockPaquetes)
            {
                if(!(t is null) && t.IsAlive)
                {
                    t.Abort();
                }
            }
        }




    }
}
