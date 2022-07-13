namespace Ejercicio_Patrones.Ejercitos.Infanteria
{
    public class Ametrallador: EntidadMilitar, IInfanteria
    {
        public double precio { get => 400; set => establecerPrecio(value); }
        public string nombre { get => "Unidad de combate terrestre con ametralladora"; set => establecerNombre(value); }
        public double velocidad { get => 4; set => establecerVelocidad(value); }
        public double blindaje { get => 0; set => establecerBlindaje(value); }
        public double potencia_fuego { get => 10; set => establecerPotenciaFuego(value); }

        public Ametrallador()
        {
            establecerBlindaje(this.blindaje);
            establecerNombre(this.nombre);
            establecerVelocidad(this.velocidad);
            establecerPotenciaFuego(this.potencia_fuego);
            establecerPrecio(this.precio);
            establecerTipo("infanteria");
        }
    }
}
