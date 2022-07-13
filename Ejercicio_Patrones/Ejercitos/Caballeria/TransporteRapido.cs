namespace Ejercicio_Patrones.Ejercitos.Caballeria
{
    public class TransporteRapido: EntidadMilitar, ICaballeria
    {
        public double precio { get => 1600; set => establecerPrecio(value); }
        public string nombre { get => "Transporte rápido TAXIN-66"; set => establecerNombre(value); }
        public double velocidad { get => 12; set => establecerVelocidad(value); }
        public double blindaje { get => 0; set => establecerBlindaje(value); }
        public double potencia_fuego { get => 0; set => establecerPotenciaFuego(value); }

        public TransporteRapido()
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
