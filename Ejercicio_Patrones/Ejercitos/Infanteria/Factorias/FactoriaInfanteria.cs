using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Infanteria.Factorias
{
    public class FactoriaInfanteria : IFactoriaInfanteria
    {
        public IInfanteria CrearAmetrallador()
        {
            return new Ametrallador();
        }

        public IInfanteria CrearBasica()
        {
            return new Basica();
        }

        public IInfanteria CrearSanitario()
        {
            return new Sanitario();
        }
    }
}
