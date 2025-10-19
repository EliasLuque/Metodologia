public class FabricaDeJugadores : FabricaDeComparables
{
    public override Comparable crearAleatorio()
    {
        string n = obtencionDeDatos.stringAleatorio(5);
        int d = obtencionDeDatos.numeroAleatorio(10000000);
        return new Jugador(n, d);
    }

    public override Comparable crearPorArchivo()
    {
        string n = obtencionDeDatos.stringDesdeArchivo(5);
        int d = (int)obtencionDeDatos.numeroDesdeArchivo(10000000);
        return new Jugador(n, d);
    }

    public override Comparable crearPorTeclado()
    {
        Console.WriteLine("Ingrese los siguientes datos");
        Console.Write("Nombre: ");
        string n = obtencionDeDatos.stringPorTeclado();
        Console.Write("DNI: ");
        int d = obtencionDeDatos.numeroPorTeclado();
        return new Jugador(n, d);
    }
}