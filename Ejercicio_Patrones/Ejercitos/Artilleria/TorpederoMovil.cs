using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Artilleria
{
    public class TorpederoMovil: Tropa, ITropa
    {
        private double precio = 1350;
        private string nombre = "Torpedero Móvil";
        private double velocidad = 3;
        private double blindaje = 2;
        private double potencia_fuego = 19;

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
