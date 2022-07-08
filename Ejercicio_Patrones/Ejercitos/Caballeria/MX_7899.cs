using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Caballeria
{
    public class MX_7899: Tropa, ITropa
    {
        private double precio = 4200;
        private string nombre = "Transporte MX-7899";
        private double velocidad = 4.5;
        private double blindaje = 1.4;
        private double potencia_fuego = 0;

        public MX_7899() : base()
        {
            base.establecerBlindaje(this.blindaje);
            base.establecerNombre(this.nombre);
            base.establecerVelocidad(this.velocidad);
            base.establecerPotenciaFuego(this.potencia_fuego);
            base.establecerPrecio(this.precio);
            base.establecerTipo("caballeria");
        }
    }
}
