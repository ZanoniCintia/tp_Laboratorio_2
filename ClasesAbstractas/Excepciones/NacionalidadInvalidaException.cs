using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException:Exception
    {
        public NacionalidadInvalidaException()
            : base("La nacionalidad no se condice con el número de DNI")
        {

        }
        public NacionalidadInvalidaException(string message)
            : base(message)
        {

        }
    }
}
