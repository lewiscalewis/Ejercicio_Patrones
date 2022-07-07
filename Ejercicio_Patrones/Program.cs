// See https://aka.ms/new-console-template for more information
using Ejercicio_Patrones.Ejercitos;


Tropa e1 = new Tropa("xd", 20, 10, 10, 1000);
Tropa e2 = new Tropa("xd", 20, 10, 10, 1200);

Ejercito_Composite artilleria = new Ejercito_Composite();

artilleria.MeterTropa(e1);
artilleria.MeterTropa(e2);

Console.WriteLine($"Coste total: {artilleria.obtenerPrecio()}$");
Console.WriteLine($"Blindaje total: {artilleria.obtenerBlindaje()}");
Console.WriteLine($"Capacidad militar total: {artilleria.obtener_CM()}");
