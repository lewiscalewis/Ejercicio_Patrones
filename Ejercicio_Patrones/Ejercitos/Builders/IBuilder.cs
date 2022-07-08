using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Builders
{
    public interface IBuilder
    {
        ITropa CrearEjercitoArtilleria();
        ITropa CrearEjercitoInfanteria();
        ITropa CrearEjercitoCaballeria();
    }
}
