namespace Ejercicio_Patrones.Ejercitos.Caballeria
{
    public class TanqueAtaqueSombras: EntidadMilitar, ICaballeria
    {
        public double precio { get => 15600; set => establecerPrecio(value); }
        public string nombre { get => "Tanque de ataque Sombras-VB98"; set => establecerNombre(value); }
        public double velocidad { get => 7.3; set => establecerVelocidad(value); }
        public double blindaje { get => 4.8; set => establecerBlindaje(value); }
        public double potencia_fuego { get => 9.8; set => establecerPotenciaFuego(value); }

        public TanqueAtaqueSombras()
        {
            establecerBlindaje(this.blindaje);
            establecerNombre(this.nombre);
            establecerVelocidad(this.velocidad);
            establecerPotenciaFuego(this.potencia_fuego);
            establecerPrecio(this.precio);
            establecerTipo("caballeria");
        }
    }
}
