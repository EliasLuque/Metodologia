public class FabricaDeJugadores : FabricaDeComparables
{
    public override Comparable crearAleatorio()
    {
        string n = generador.stringAleatorio(5);
        int d = generador.numeroAleatorio(10000000);
        return new Jugador(n, d);
    }

    public override Comparable crearPorTeclado()
    {
        Console.WriteLine("Ingrese los siguientes datos");
        Console.Write("Nombre: ");
        string n = lector.stringPorTeclado();
        Console.Write("DNI: ");
        int d = lector.numeroPorTeclado();
        return new Jugador(n, d);
    }
}