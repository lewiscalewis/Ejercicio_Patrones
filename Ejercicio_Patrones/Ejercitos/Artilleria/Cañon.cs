using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Artilleria
{
    public class Cañon : EntidadMilitar, IArtilleria
    {
        public double precio { get => 1100; set => base.establecerPrecio(value); }
        public string nombre { get => "Cañon"; set => base.establecerNombre(value); }
        public double velocidad { get => 0; set => base.establecerVelocidad(value); }
        public double blindaje { get => 0; set => base.establecerBlindaje(value); }
        public double potencia_fuego { get => 14; set => base.establecerPotenciaFuego(value); }

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
