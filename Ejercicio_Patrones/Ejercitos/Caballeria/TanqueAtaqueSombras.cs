using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Caballeria
{
    public class TanqueAtaqueSombras: EntidadMilitar, ICaballeria
    {
        public double precio { get; set; } = 15600;
        public string nombre { get; set; } = "Tanque de ataque Sombras-VB98";
        public double velocidad { get; set; } = 7.3;
        public double blindaje { get; set; } = 4.8;
        public double potencia_fuego { get; set; } = 9.8;

        public TanqueAtaqueSombras() : base()
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
