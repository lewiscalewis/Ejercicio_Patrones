namespace Ejercicio_Patrones.Ejercitos.Artilleria
{
    public class AntiAereo : EntidadMilitar, IArtilleria
    {

        public double Precio { get => 1100; set => establecerPrecio(value); }
        public string Nombre { get => "Cañon Antiaereo"; set => establecerNombre(value); }
        public double Velocidad { get => 1; set => establecerVelocidad(value); }
        public double Blindaje { get => 0; set => establecerBlindaje(value); }
        public double Potencia_fuego { get => 22; set => establecerPotenciaFuego(value); }

        public AntiAereo()
        {
            establecerBlindaje(this.Blindaje);
            establecerNombre(this.Nombre);
            establecerVelocidad(this.Velocidad);
            establecerPotenciaFuego(this.Potencia_fuego);
            establecerPrecio(this.Precio);
            establecerTipo("artilleria");
        }


    }
}
