using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Artilleria
{
    public class Cañon : Tropa, ITropa, IArtilleria
    {
        private double precio = 1100;
        private string nombre = "Cañon";
        private double velocidad = 0;
        private double blindaje = 0;
        private double potencia_fuego = 14;

        public Cañon() : base()
        {
            base.establecerBlindaje(this.blindaje);
            base.establecerNombre(this.nombre);
            base.establecerVelocidad(this.velocidad);
            base.establecerPotenciaFuego(this.potencia_fuego);
            base.establecerPrecio(this.precio);
            base.establecerTipo("artilleria");
        }
    }
}
