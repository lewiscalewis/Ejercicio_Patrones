using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Artilleria
{
    public class TorpederoMovil: EntidadMilitar, IArtilleria
    {
        public double precio { get; set; } = 1350;
        public string nombre { get; set; } = "Torpedero Móvil";
        public double velocidad { get; set; } = 3;
        public double blindaje { get; set; } = 2;
        public double potencia_fuego { get; set; } = 19;

        public TorpederoMovil() : base()
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
