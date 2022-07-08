using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Caballeria
{
    public class TransporteRapido: EntidadMilitar, ICaballeria
    {
        public double precio { get; set; } = 1600;
        public string nombre { get; set; } = "Transporte rápido TAXIN-66";
        public double velocidad { get; set; } = 12;
        public double blindaje { get; set; } = 0;
        public double potencia_fuego { get; set; } = 0;

        public TransporteRapido() : base()
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
