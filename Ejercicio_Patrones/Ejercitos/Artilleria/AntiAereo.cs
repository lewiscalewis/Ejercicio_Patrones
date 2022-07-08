using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Artilleria
{
    public class AntiAereo : EntidadMilitar, IArtilleria
    {

        public double precio { get; set; } = 1100;
        public string nombre { get; set; } = "Cañon Antiaereo";
        public double velocidad { get; set; } = 1;
        public double blindaje { get; set; } = 0;
        public double potencia_fuego { get; set; } = 22;

        public AntiAereo() : base()
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
