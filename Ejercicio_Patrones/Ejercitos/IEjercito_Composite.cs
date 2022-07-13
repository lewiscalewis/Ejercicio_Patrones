namespace Ejercicio_Patrones.Ejercitos
{
    public interface IEjercito_Composite
    {
        void MeterTropa(IEntidadMilitar tropa);
        void QuitarTropa(IEntidadMilitar tropa);
    }
}
