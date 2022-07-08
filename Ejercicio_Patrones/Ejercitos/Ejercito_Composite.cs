using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos
{
    public class Ejercito_Composite : EntidadMilitar, IEntidadMilitar, IEjercito_Composite
    {
        private List<IEntidadMilitar> tropas = new List<IEntidadMilitar>();
        private double precio = 0;
        private string nombre = "";
        private double velocidad = 0;
        private double blindaje = 0;
        private double potencia_fuego = 0;

        public void MeterTropa(IEntidadMilitar tropa)
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

        public override int ObtenerTropas()
        {
            int total = 0;

            foreach(IEntidadMilitar item in tropas)
            {
                try
                {
                    total += item.ObtenerTropas();
                }
                catch (Exception e)
                {
                    total++;
                }
                
            }
            return total;
        }

        public void QuitarTropa(IEntidadMilitar tropa)
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
