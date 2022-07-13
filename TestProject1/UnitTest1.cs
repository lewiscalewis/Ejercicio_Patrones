using Ejercicio_Patrones.Ejercitos;
using Ejercicio_Patrones.Ejercitos.Artilleria.Factorias;
using Ejercicio_Patrones.Ejercitos.Builders;
using Ejercicio_Patrones.Ejercitos.Caballeria.Factorias;
using Ejercicio_Patrones.Ejercitos.Infanteria.Factorias;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private FactoriaArtilleria artilleria;
        private FactoriaCaballeria caballeria;
        private FactoriaInfanteria infanteria;
        private BuilderEjercito builder;
        private BuilderEjercitosCompuestos builder_compuesto;

        [TestInitialize]
        public void Setup()
        {
            this.artilleria = new FactoriaArtilleria();
            this.caballeria = new FactoriaCaballeria();
            this.infanteria = new FactoriaInfanteria();
            this.builder = new BuilderEjercito();
            this.builder_compuesto = new BuilderEjercitosCompuestos();
        }
        [TestMethod]
        public void TestMethodEstadisticasArtilleria()
        {
            //Antiaereo
                //Blindaje
            Assert.AreEqual(0, (artilleria.CrearAntiaereo() as IEntidadMilitar).obtenerBlindaje());
                //Movilidad
            Assert.AreEqual(1, (artilleria.CrearAntiaereo() as IEntidadMilitar).obtenerVelocidad());
                //Potencia de fuego
            Assert.AreEqual(22, (artilleria.CrearAntiaereo() as IEntidadMilitar).obtenerPotenciaFuego());
                //Precio
            Assert.AreEqual(1100, (artilleria.CrearAntiaereo() as IEntidadMilitar).obtenerPrecio());


            //Cañon
                //Blindaje
            Assert.AreEqual(0, (artilleria.CrearCañon() as IEntidadMilitar).obtenerBlindaje());
                //Movilidad
            Assert.AreEqual(0, (artilleria.CrearCañon() as IEntidadMilitar).obtenerVelocidad());
                //Potencia de fuego
            Assert.AreEqual(14, (artilleria.CrearCañon() as IEntidadMilitar).obtenerPotenciaFuego());
                //Precio
            Assert.AreEqual(1100, (artilleria.CrearCañon() as IEntidadMilitar).obtenerPrecio());


            //Torpedero móvil
                //Blindaje
            Assert.AreEqual(2, (artilleria.CrearTorpederoMovil() as IEntidadMilitar).obtenerBlindaje());
                //Movilidad
            Assert.AreEqual(3, (artilleria.CrearTorpederoMovil() as IEntidadMilitar).obtenerVelocidad());
                //Potencia de fuego
            Assert.AreEqual(19, (artilleria.CrearTorpederoMovil() as IEntidadMilitar).obtenerPotenciaFuego());
                //Precio
            Assert.AreEqual(1350, (artilleria.CrearTorpederoMovil() as IEntidadMilitar).obtenerPrecio());
        }

        [TestMethod]
        public void TestMethodEstadisticasCaballeria()
        {
            //mx 7899
            //Blindaje
            Assert.AreEqual(1.4, (caballeria.CrearMX_7899() as IEntidadMilitar).obtenerBlindaje());
            //Movilidad
            Assert.AreEqual(4.5, (caballeria.CrearMX_7899() as IEntidadMilitar).obtenerVelocidad());
            //Potencia de fuego
            Assert.AreEqual(0, (caballeria.CrearMX_7899() as IEntidadMilitar).obtenerPotenciaFuego());
            //Precio
            Assert.AreEqual(4200, (caballeria.CrearMX_7899() as IEntidadMilitar).obtenerPrecio());


            //Tanque sombras
            //Blindaje
            Assert.AreEqual(4.8, (caballeria.CrearTanqueSombras() as IEntidadMilitar).obtenerBlindaje());
            //Movilidad
            Assert.AreEqual(7.3, (caballeria.CrearTanqueSombras() as IEntidadMilitar).obtenerVelocidad());
            //Potencia de fuego
            Assert.AreEqual(9.8, (caballeria.CrearTanqueSombras() as IEntidadMilitar).obtenerPotenciaFuego());
            //Precio
            Assert.AreEqual(15600, (caballeria.CrearTanqueSombras() as IEntidadMilitar).obtenerPrecio());


            //Transporte rápido
            //Blindaje
            Assert.AreEqual(0, (caballeria.CrearTransporteRapido() as IEntidadMilitar).obtenerBlindaje());
            //Movilidad
            Assert.AreEqual(12, (caballeria.CrearTransporteRapido() as IEntidadMilitar).obtenerVelocidad());
            //Potencia de fuego
            Assert.AreEqual(0, (caballeria.CrearTransporteRapido() as IEntidadMilitar).obtenerPotenciaFuego());
            //Precio
            Assert.AreEqual(1600, (caballeria.CrearTransporteRapido() as IEntidadMilitar).obtenerPrecio());
        }

        [TestMethod]
        public void TestMethodEstadisticasInfanteria()
        {
            //Ametrallador
            //Blindaje
            Assert.AreEqual(0, (infanteria.CrearAmetrallador() as IEntidadMilitar).obtenerBlindaje());
            //Movilidad
            Assert.AreEqual(4, (infanteria.CrearAmetrallador() as IEntidadMilitar).obtenerVelocidad());
            //Potencia de fuego
            Assert.AreEqual(10, (infanteria.CrearAmetrallador() as IEntidadMilitar).obtenerPotenciaFuego());
            //Precio
            Assert.AreEqual(400, (infanteria.CrearAmetrallador() as IEntidadMilitar).obtenerPrecio());


            //Basica
            //Blindaje
            Assert.AreEqual(0, (infanteria.CrearBasica() as IEntidadMilitar).obtenerBlindaje());
            //Movilidad
            Assert.AreEqual(6, (infanteria.CrearBasica() as IEntidadMilitar).obtenerVelocidad());
            //Potencia de fuego
            Assert.AreEqual(7, (infanteria.CrearBasica() as IEntidadMilitar).obtenerPotenciaFuego());
            //Precio
            Assert.AreEqual(250, (infanteria.CrearBasica() as IEntidadMilitar).obtenerPrecio());


            //Sanitario
            //Blindaje
            Assert.AreEqual(5, (infanteria.CrearSanitario() as IEntidadMilitar).obtenerBlindaje());
            //Movilidad
            Assert.AreEqual(7, (infanteria.CrearSanitario() as IEntidadMilitar).obtenerVelocidad());
            //Potencia de fuego
            Assert.AreEqual(0, (infanteria.CrearSanitario() as IEntidadMilitar).obtenerPotenciaFuego());
            //Precio
            Assert.AreEqual(500, (infanteria.CrearSanitario() as IEntidadMilitar).obtenerPrecio());
        }

        [TestMethod]
        public void TestMethodBuilders()
        {
            Assert.IsTrue(builder.CrearEjercitoArtilleria() is IEntidadMilitar);
            Assert.IsTrue(builder.CrearEjercitoCaballeria() is IEntidadMilitar);
            Assert.IsTrue(builder.CrearEjercitoInfanteria() is IEntidadMilitar);
        }

        [TestMethod]
        public void TestMethodBuildersCompuestos()
        {
            Assert.IsTrue(builder_compuesto.CrearEjercitoCompleto() is IEntidadMilitar);
            Assert.IsTrue(builder_compuesto.CrearArtilleriaInfanteria() is IEntidadMilitar);
            Assert.IsTrue(builder_compuesto.CrearCaballeriaArtilleria() is IEntidadMilitar);
            Assert.IsTrue(builder_compuesto.CrearCaballeriaInfanteria() is IEntidadMilitar);
        }
    }
}