using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Artilleria
{
    public class Ejercito_Artilleria_Composite : Tropa, ITropa, IEjercito_Composite
    {
        private List<ITropa> tropas = new List<ITropa>();
        private double precio = 0;
        private double velocidad = 0;
        private double blindaje = 0;
        private double potencia_fuego = 0;
        private string tipo = "artilleria";

       
        public void MeterTropa(ITropa tropa)
        {
            if (this.tipo.Equals(tropa.obtenerTipo()))
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
            else
            {
                Console.WriteLine("No se ha introducido una tropa del tipo artilleria");
            }
            
        }

        public override int ObtenerTropas()
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
