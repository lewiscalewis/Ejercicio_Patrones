using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Caballeria
{
    public class MX_7899: EntidadMilitar, ICaballeria
    {
        public double precio { get; set; } = 4200;
        public string nombre { get; set; } = "Transporte MX-7899";
        public double velocidad { get; set; } = 4.5;
        public double blindaje { get; set; } = 1.4;
        public double potencia_fuego { get; set; } = 0;

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
