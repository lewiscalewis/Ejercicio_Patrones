namespace Ejercicio_Patrones.Ejercitos.Artilleria
{
    public class TorpederoMovil: EntidadMilitar, IArtilleria
    {
        public double precio { get => 1350; set => establecerPrecio(value); }
        public string nombre { get => "Torpedero Móvil"; set => establecerNombre(value); }
        public double velocidad { get => 3; set => establecerVelocidad(value); }
        public double blindaje { get => 2; set => establecerBlindaje(value); }
        public double potencia_fuego { get => 19; set => establecerPotenciaFuego(value); }

        public TorpederoMovil()
        {
            establecerBlindaje(this.blindaje);
            establecerNombre(this.nombre);
            establecerVelocidad(this.velocidad);
            establecerPotenciaFuego(this.potencia_fuego);
            establecerPrecio(this.precio);
            establecerTipo("artilleria");
        }
    }
}
