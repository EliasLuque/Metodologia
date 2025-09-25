public class FabricaDeProfesores : FabricaDeComparables
{
    public override Comparable crearAleatorio()
    {
        string n = generador.stringAleatorio(5);
        int d = generador.numeroAleatorio(10000000);
        int a = generador.numeroAleatorio(10);
        return new Profesor(n, d, a);
    }

    public override Comparable crearPorTeclado()
    {
        Console.WriteLine("Ingrese los siguientes datos");
       
        Console.Write("Nombre: ");
        string n = lector.stringPorTeclado();

        Console.Write("DNI: ");
        int d = lector.numeroPorTeclado();

        Console.Write("Antigüedad: ");
        int a = lector.numeroPorTeclado();

        return new Profesor(n, d, a);
    }
}