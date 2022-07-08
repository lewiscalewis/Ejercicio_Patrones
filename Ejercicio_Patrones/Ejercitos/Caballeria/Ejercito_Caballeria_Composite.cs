using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Caballeria
{
    public class Ejercito_Caballeria_Composite : EntidadMilitar, IEntidadMilitar, IEjercito_Composite
    {
        private List<IEntidadMilitar> tropas = new List<IEntidadMilitar>();
        private double precio = 0;
        private double velocidad = 0;
        private double blindaje = 0;
        private double potencia_fuego = 0;
        private string tipo = "caballeria";


        public void MeterTropa(IEntidadMilitar tropa)
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
                Console.WriteLine("No se ha introducido una tropa del tipo caballeria");
            }

        }

        public override int ObtenerTropas()
        {
            return tropas.Count;
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
