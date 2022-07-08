using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Artilleria
{
    public class TorpederoMovil: EntidadMilitar, IArtilleria
    {
        public double precio { get => 1350; set => base.establecerPrecio(value); }
        public string nombre { get => "Torpedero Móvil"; set => base.establecerNombre(value); }
        public double velocidad { get => 3; set => base.establecerVelocidad(value); }
        public double blindaje { get => 2; set => base.establecerBlindaje(value); }
        public double potencia_fuego { get => 19; set => base.establecerPotenciaFuego(value); }

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
