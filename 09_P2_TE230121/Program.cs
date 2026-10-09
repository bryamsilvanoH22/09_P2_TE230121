// Ejercicio 9: Evaluación y comparación de dos bombas eléctricas

Console.WriteLine("SISTEMA DE EVALUACION DE BOMBAS ELECTRICAS");
Console.WriteLine();

// Objeto: Se instancia el primer objeto "bomba1" a partir de la clase BombaElectrica
BombaElectrica bomba1 = new BombaElectrica();

Console.WriteLine("--- DATOS DE LA BOMBA 1 ---");
Console.Write("Ingrese el identificador de la bomba 1: ");
bomba1.Identificador = Console.ReadLine() ?? "Bomba 1";

Console.Write("Ingrese el voltaje de alimentación (V): ");
bomba1.Voltaje = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente consumida (A): ");
bomba1.Corriente = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el caudal (L/min): ");
bomba1.Caudal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

// Objeto: Se instancia el segundo objeto "bomba2" a partir de la clase BombaElectrica
BombaElectrica bomba2 = new BombaElectrica();

Console.WriteLine("--- DATOS DE LA BOMBA 2 ---");
Console.Write("Ingrese el identificador de la bomba 2: ");
bomba2.Identificador = Console.ReadLine() ?? "Bomba 2";

Console.Write("Ingrese el voltaje de alimentación (V): ");
bomba2.Voltaje = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente consumida (A): ");
bomba2.Corriente = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el caudal (L/min): ");
bomba2.Caudal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

// Cálculo de potencias e indicadores para ambas bombas
double potencia1 = bomba1.CalcularPotencia();
double potencia2 = bomba2.CalcularPotencia();
double indicador1 = bomba1.CalcularIndicador();
double indicador2 = bomba2.CalcularIndicador();

// Mostrar resultados individuales con unidades correspondientes
Console.WriteLine("--- RESULTADOS ---");
Console.WriteLine($"Bomba: {bomba1.Identificador} | Potencia: {potencia1:F2} W | Indicador: {indicador1:F4} (L/min)/W");
Console.WriteLine($"Bomba: {bomba2.Identificador} | Potencia: {potencia2:F2} W | Indicador: {indicador2:F4} (L/min)/W");
Console.WriteLine();

// Comparación de los indicadores para señalar cuál bomba entrega más caudal por watt o si existe empate
if (indicador1 > indicador2)
{
    Console.WriteLine($"La bomba '{bomba1.Identificador}' entrega más caudal por watt.");
}
else if (indicador2 > indicador1)
{
    Console.WriteLine($"La bomba '{bomba2.Identificador}' entrega más caudal por watt.");
}
else
{
    Console.WriteLine("Existe un empate; ambas bombas entregan el mismo caudal por watt.");
}


// Clase: Definición de la clase BombaElectrica
class BombaElectrica
{
    // Propiedad: Almacena el identificador de la bomba
    public string Identificador { get; set; } = "";

    // Propiedad: Almacena el voltaje en volts (V)
    public double Voltaje { get; set; }

    // Propiedad: Almacena la corriente en amperes (A)
    public double Corriente { get; set; }

    // Propiedad: Almacena el caudal en litros por minuto (L/min)
    public double Caudal { get; set; }

    // Método: Calcula la potencia eléctrica (P = V * I) en watts (W)
    public double CalcularPotencia()
    {
        return Voltaje * Corriente;
    }

    // Método: Calcula el indicador didáctico de desempeño (caudal / potencia) evitando división entre cero
    public double CalcularIndicador()
    {
        double potencia = CalcularPotencia();
        if (potencia <= 0)
        {
            return 0.0;
        }
        return Caudal / potencia;
    }
}
