using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Caballeria.Factorias
{
    public interface IFactoriaCaballeria
    {
        ICaballeria CrearMX_7899();
        ICaballeria CrearTanqueSombras();
        ICaballeria CrearTransporteRapido();
    }
}
