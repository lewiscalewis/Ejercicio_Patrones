namespace Ejercicio_Patrones.Ejercitos.Caballeria
{
    public class MX_7899: EntidadMilitar, ICaballeria
    {
        public double precio { get => 4200; set => establecerPrecio(value); }
        public string nombre { get => "Transporte MX-7899"; set => establecerNombre(value); }
        public double velocidad { get => 4.5; set => establecerVelocidad(value); }
        public double blindaje { get => 1.4; set => establecerBlindaje(value); }
        public double potencia_fuego { get => 0; set => establecerPotenciaFuego(value); }

        public MX_7899()
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
