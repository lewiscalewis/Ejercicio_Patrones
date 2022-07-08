using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos
{
    public class Ejercito_Composite : Tropa, ITropa, IEjercito_Composite
    {
        private List<ITropa> tropas = new List<ITropa>();
        private double precio = 0;
        private string nombre = "";
        private double velocidad = 0;
        private double blindaje = 0;
        private double potencia_fuego = 0;

        public void MeterTropa(ITropa tropa)
        {
            tropas.Add(tropa);

            precio += tropa.obtenerPrecio();
            base.establecerPrecio(precio);

            velocidad += tropa.obtenerVelocidad();
            base.establecerVelocidad(velocidad);

            blindaje += tropa.obtenerBlindaje();
            base.establecerBlindaje(blindaje);

            potencia_fuego += tropa.obtenerPotenciaFuego();
            base.establecerPotenciaFuego(potencia_fuego);
        }

        public int ObtenerTropas()
        {
            return tropas.Count;
        }

        public void QuitarTropa(ITropa tropa)
        {
            tropas.Remove(tropa);
            precio -= tropa.obtenerPrecio();
            base.establecerPrecio(precio);

            velocidad -= tropa.obtenerVelocidad();
            base.establecerVelocidad(velocidad);

            blindaje -= tropa.obtenerBlindaje();
            base.establecerBlindaje(blindaje);

            potencia_fuego -= tropa.obtenerPotenciaFuego();
            base.establecerPotenciaFuego(potencia_fuego);
        }

    }
}
