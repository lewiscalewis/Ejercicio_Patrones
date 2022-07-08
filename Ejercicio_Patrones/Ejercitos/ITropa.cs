using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos
{
    public interface ITropa
    {
        void establecerNombre(string nombre);
        void establecerVelocidad(double velocidad);
        void establecerBlindaje(double blindaje);
        void establecerPotenciaFuego(double potencia_fuego);
        void establecerPrecio(double precio);
        void establecerTipo(string tipo);
        string obtenerNombre();
        double obtenerVelocidad();
        double obtenerBlindaje();
        double obtenerPotenciaFuego();
        double obtenerPrecio();
        double obtener_CM();
        string obtenerTipo();
        int ObtenerTropas();
    }
}
