using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Caballeria
{
    public class TanqueAtaqueSombras: EntidadMilitar, ICaballeria
    {
        public double precio { get => 15600; set => base.establecerPrecio(value); }
        public string nombre { get => "Tanque de ataque Sombras-VB98"; set => base.establecerNombre(value); }
        public double velocidad { get => 7.3; set => base.establecerVelocidad(value); }
        public double blindaje { get => 4.8; set => base.establecerBlindaje(value); }
        public double potencia_fuego { get => 9.8; set => base.establecerPotenciaFuego(value); }

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
