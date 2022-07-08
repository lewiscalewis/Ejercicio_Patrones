using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Infanteria.Factorias
{
    public interface IFactoriaInfanteria
    {
        IInfanteria CrearAmetrallador();
        IInfanteria CrearBasica();
        IInfanteria CrearSanitario();
    }
}
