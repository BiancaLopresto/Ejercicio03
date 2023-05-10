// See https://aka.ms/new-console-template for more information
int Grado;
double Multiplicacion;

Console.Write("Ingrese los grados:");
Grado = int.Parse(Console.ReadLine());

Multiplicacion = Grado * 0.0174532925;

Console.WriteLine($"Los grados pasados a Radianes son: {Multiplicacion} ");
