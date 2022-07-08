using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos
{
    public interface IEjercito_Composite
    {
        void MeterTropa(ITropa tropa);
        void QuitarTropa(ITropa tropa);
    }
}
