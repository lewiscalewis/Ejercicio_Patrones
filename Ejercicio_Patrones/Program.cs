// See https://aka.ms/new-console-template for more information
using Ejercicio_Patrones.Ejercitos;
using Ejercicio_Patrones.Ejercitos.Builders;

BuilderEjercitosCompuestos ejercito_general = new BuilderEjercitosCompuestos();
var ejercito = ejercito_general.CrearArtilleriaInfanteria();
EntidadMilitar m = new EntidadMilitar();

//logs
Console.WriteLine($"Coste total: {ejercito.obtenerPrecio()}$");
Console.WriteLine($"Velocidad total: {ejercito.obtenerVelocidad()}");
Console.WriteLine($"Potencia de Fuego total: {ejercito.obtenerPotenciaFuego()}");
Console.WriteLine($"Blindaje total: {ejercito.obtenerBlindaje()}");
Console.WriteLine($"Capacidad militar total: {ejercito.obtener_CM()}");
Console.WriteLine($"Tropas totales: {ejercito.ObtenerTropas()}");
