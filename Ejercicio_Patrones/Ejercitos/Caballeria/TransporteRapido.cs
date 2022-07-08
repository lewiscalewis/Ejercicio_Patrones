using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Caballeria
{
    public class TransporteRapido: EntidadMilitar, ICaballeria
    {
        public double precio { get => 1600; set => base.establecerPrecio(value); }
        public string nombre { get => "Transporte rápido TAXIN-66"; set => base.establecerNombre(value); }
        public double velocidad { get => 12; set => base.establecerVelocidad(value); }
        public double blindaje { get => 0; set => base.establecerBlindaje(value); }
        public double potencia_fuego { get => 0; set => base.establecerPotenciaFuego(value); }

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
