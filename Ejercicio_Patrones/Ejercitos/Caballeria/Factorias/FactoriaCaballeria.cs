namespace Ejercicio_Patrones.Ejercitos.Caballeria.Factorias
{
    public class FactoriaCaballeria : IFactoriaCaballeria
    {
        public ICaballeria CrearMX_7899()
        {
            return new MX_7899();
        }

        public ICaballeria CrearTanqueSombras()
        {
            return new TanqueAtaqueSombras();
        }

        public ICaballeria CrearTransporteRapido()
        {
            return new TransporteRapido();
        }
    }
}
