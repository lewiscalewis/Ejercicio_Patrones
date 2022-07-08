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
        public IEntidadMilitar CrearEjercitoArtilleria()
        {
            FactoriaArtilleria factoriaArtilleria = new FactoriaArtilleria();
            IEntidadMilitar tropa1 = (IEntidadMilitar)factoriaArtilleria.CrearAntiaereo();
            IEntidadMilitar tropa2 = (IEntidadMilitar)factoriaArtilleria.CrearCañon();
            IEntidadMilitar tropa3 = (IEntidadMilitar)factoriaArtilleria.CrearTorpederoMovil();

            Ejercito_Artilleria_Composite artilleria = new Ejercito_Artilleria_Composite();
            artilleria.MeterTropa(tropa1);
            artilleria.MeterTropa(tropa2);
            artilleria.MeterTropa(tropa3);

            return artilleria;
        }

        public IEntidadMilitar CrearEjercitoCaballeria()
        {
            FactoriaCaballeria factoriaCaballeria = new FactoriaCaballeria();
            IEntidadMilitar tropa1 = (IEntidadMilitar)factoriaCaballeria.CrearTanqueSombras();
            IEntidadMilitar tropa2 = (IEntidadMilitar)factoriaCaballeria.CrearTransporteRapido();
            IEntidadMilitar tropa3 = (IEntidadMilitar)factoriaCaballeria.CrearMX_7899();

            Ejercito_Caballeria_Composite caballeria = new Ejercito_Caballeria_Composite();
            caballeria.MeterTropa(tropa1);
            caballeria.MeterTropa(tropa2);
            caballeria.MeterTropa(tropa3);

            return caballeria;
        }

        public IEntidadMilitar CrearEjercitoInfanteria()
        {
            FactoriaInfanteria factoriaInfanteria = new FactoriaInfanteria();  
            IEntidadMilitar tropa1 = (IEntidadMilitar)factoriaInfanteria.CrearSanitario();
            IEntidadMilitar tropa2 = (IEntidadMilitar)factoriaInfanteria.CrearBasica();
            IEntidadMilitar tropa3 = (IEntidadMilitar)factoriaInfanteria.CrearAmetrallador();

            Ejercito_Infanteria_Composite infanteria = new Ejercito_Infanteria_Composite();
            infanteria.MeterTropa(tropa1);
            infanteria.MeterTropa(tropa2);
            infanteria.MeterTropa(tropa3);

            return infanteria;
        }
    }
}
