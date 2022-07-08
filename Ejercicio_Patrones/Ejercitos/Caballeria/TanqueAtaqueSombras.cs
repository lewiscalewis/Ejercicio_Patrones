using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Caballeria
{
    public class TanqueAtaqueSombras: Tropa, ITropa
    {
        private double precio = 15600;
        private string nombre = "Tanque de ataque Sombras-VB98";
        private double velocidad = 7.3;
        private double blindaje = 4.8;
        private double potencia_fuego = 9.8;

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
