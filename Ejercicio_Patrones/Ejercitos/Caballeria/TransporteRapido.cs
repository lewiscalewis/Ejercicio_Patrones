using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Caballeria
{
    public class TransporteRapido: Tropa, ITropa, ICaballeria
    {
        private double precio = 1600;
        private string nombre = "Transporte rápido TAXIN-66";
        private double velocidad = 12;
        private double blindaje = 0;
        private double potencia_fuego = 0;

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
