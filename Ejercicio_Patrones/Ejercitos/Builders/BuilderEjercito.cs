using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Patrones.Ejercitos.Artilleria;
using Ejercicio_Patrones.Ejercitos.Caballeria;
using Ejercicio_Patrones.Ejercitos.Infanteria;
using Ejercicio_Patrones.Ejercitos.Artilleria.Factorias;
using Ejercicio_Patrones.Ejercitos.Caballeria.Factorias;
using Ejercicio_Patrones.Ejercitos.Infanteria.Factorias;

namespace Ejercicio_Patrones.Ejercitos.Builders
{
    public class BuilderEjercito : IBuilder
    {
        public ITropa CrearEjercitoArtilleria()
        {
            FactoriaArtilleria factoriaArtilleria = new FactoriaArtilleria();
            ITropa tropa1 = (ITropa)factoriaArtilleria.CrearAntiaereo();
            ITropa tropa2 = (ITropa)factoriaArtilleria.CrearCañon();
            ITropa tropa3 = (ITropa)factoriaArtilleria.CrearTorpederoMovil();

            Ejercito_Artilleria_Composite artilleria = new Ejercito_Artilleria_Composite();
            artilleria.MeterTropa(tropa1);
            artilleria.MeterTropa(tropa2);
            artilleria.MeterTropa(tropa3);

            return artilleria;
        }

        public ITropa CrearEjercitoCaballeria()
        {
            FactoriaCaballeria factoriaCaballeria = new FactoriaCaballeria();
            ITropa tropa1 = (ITropa)factoriaCaballeria.CrearTanqueSombras();
            ITropa tropa2 = (ITropa)factoriaCaballeria.CrearTransporteRapido();
            ITropa tropa3 = (ITropa)factoriaCaballeria.CrearMX_7899();

            Ejercito_Caballeria_Composite caballeria = new Ejercito_Caballeria_Composite();
            caballeria.MeterTropa(tropa1);
            caballeria.MeterTropa(tropa2);
            caballeria.MeterTropa(tropa3);

            return caballeria;
        }

        public ITropa CrearEjercitoInfanteria()
        {
            FactoriaInfanteria factoriaInfanteria = new FactoriaInfanteria();  
            ITropa tropa1 = (ITropa)factoriaInfanteria.CrearSanitario();
            ITropa tropa2 = (ITropa)factoriaInfanteria.CrearBasica();
            ITropa tropa3 = (ITropa)factoriaInfanteria.CrearAmetrallador();

            Ejercito_Infanteria_Composite infanteria = new Ejercito_Infanteria_Composite();
            infanteria.MeterTropa(tropa1);
            infanteria.MeterTropa(tropa2);
            infanteria.MeterTropa(tropa3);

            return infanteria;
        }
    }
}
