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
        private string nombre = "";
        private double velocidad = 0;
        private double blindaje = 0;
        private double potencia_fuego = 0;
        private string tipo = "artilleria";

        public Ejercito_Artilleria_Composite()
        {
            base.establecerTipo(this.tipo);
        }
        public void MeterTropa(ITropa tropa)
        {
            if (base.obtenerTipo().Equals(this.tipo))
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
                throw new Exception();
            }
            
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

        public void QuitarTropa()
        {
            throw new NotImplementedException();
        }
    }
}
