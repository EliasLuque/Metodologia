public class FabricaDeNumeros : FabricaDeComparables
{
    public override Comparable crearAleatorio()
    {
        int valor = obtencionDeDatos.numeroAleatorio(50);
        return new Numero(valor);
    }

    public override Comparable crearPorArchivo()
    {
        int valor = (int)obtencionDeDatos.numeroDesdeArchivo(50);
        return new Numero(valor);
    }

    public override Comparable crearPorTeclado()
    {
        Console.Write("Ingrese el numero: ");
        int valor = obtencionDeDatos.numeroPorTeclado();
        return new Numero(valor);
    }
}