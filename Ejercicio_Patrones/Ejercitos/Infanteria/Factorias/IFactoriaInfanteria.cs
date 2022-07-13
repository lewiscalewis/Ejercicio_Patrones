namespace Ejercicio_Patrones.Ejercitos.Infanteria.Factorias
{
    public interface IFactoriaInfanteria
    {
        IInfanteria CrearAmetrallador();
        IInfanteria CrearBasica();
        IInfanteria CrearSanitario();
    }
}
