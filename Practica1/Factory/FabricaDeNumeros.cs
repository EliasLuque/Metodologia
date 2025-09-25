public class FabricaDeNumeros : FabricaDeComparables
{
    public override Comparable crearAleatorio()
    {
        int valor = generador.numeroAleatorio(50);
        return new Numero(valor);
    }

    public override Comparable crearPorTeclado()
    {
        Console.Write("Ingrese el numero: ");
        int valor = lector.numeroPorTeclado();
        return new Numero(valor);
    }
}