using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Artilleria
{
    public class AntiAereo : Tropa,  ITropa
    {

        private double precio = 1100;
        private string nombre = "Cañon Antiaereo";
        private double velocidad = 1;
        private double blindaje = 0;
        private double potencia_fuego = 22;

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
