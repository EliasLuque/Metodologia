public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
{
    public override Comparable crearAleatorio()
    {
        string n = generador.stringAleatorio(5);
        int d = generador.numeroAleatorio(10000000);
        int l = generador.numeroAleatorio(5000);
        double p = generador.numeroAleatorio(10);
        return new AlumnoMuyEstudioso(n, d, l, p);
    }

    public override Comparable crearPorTeclado()
    {
        Console.WriteLine("Ingrese los siguientes datos");
       
        Console.Write("Nombre: ");
        string n = lector.stringPorTeclado();

        Console.Write("DNI: ");
        int d = lector.numeroPorTeclado();

        Console.Write("Legajo: ");
        int l = lector.numeroPorTeclado();

        Console.Write("Promedio: ");
        double p = lector.numeroPorTeclado();

        return new AlumnoMuyEstudioso(n, d, l, p);
    }
}