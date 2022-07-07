using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos
{
    public class Tropa : ITropa
    {
        string nombre;
        double velocidad;
        double blindaje;
        double potencia_fuego;
        double precio;
        string tipo;

        public Tropa()
        {

        }
        public Tropa(string nombre, double velocidad, double blindaje, double potencia_fuego, double precio)
        {
            this.nombre = nombre;
            this.velocidad = velocidad;
            this.blindaje = blindaje;
            this.potencia_fuego = potencia_fuego;
            this.precio = precio;
        }

        public void establecerTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string obtenerTipo()
        {
            return this.tipo;
        }
        public void establecerBlindaje(double blindaje)
        {
            this.blindaje = blindaje;
        }

        public void establecerNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void establecerPotenciaFuego(double potencia_fuego)
        {
            this.potencia_fuego = potencia_fuego;
        }

        public void establecerPrecio(double precio)
        {
            this.precio = precio;
        }

        public void establecerVelocidad(double velocidad)
        {
            this.velocidad = velocidad;
        }

        public double obtenerBlindaje()
        {
            return this.blindaje;
        }

        public string obtenerNombre()
        {
            return this.nombre;
        }

        public double obtenerPotenciaFuego()
        {
            return this.potencia_fuego;
        }

        public double obtenerPrecio()
        {
            return this.precio;
        }

        public double obtenerVelocidad()
        {
            return this.velocidad;
        }
        public double obtener_CM()
        {
            double total = 0;

            if(velocidad != 0 && potencia_fuego != 0)
            {
                total = (potencia_fuego * (velocidad / 2)) / (100 - blindaje);
            }
            else
            {
                total = (1 * (1 / 2)) / (100 - blindaje);
            }
            

            return total;
        }
    }
}
