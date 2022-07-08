using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Artilleria
{
    public class Cañon : EntidadMilitar, IArtilleria
    {
        public double precio { get; set; } = 1100;
        public string nombre { get; set; } = "Cañon";
        public double velocidad { get; set; } = 0;
        public double blindaje { get; set; } = 0;
        public double potencia_fuego { get; set; } = 14;

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
