public class FabricaDeNumeros : FabricaDeComparables
{
    public override Comparable crearAleatorio()
    {
        GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        int valor = generador.numeroAleatorio(50);
        return new Numero(valor);
    }

    public override Comparable crearPorTeclado()
    {
        LectorDeDatos lector = new LectorDeDatos();
        Console.Write("Ingrese el numero: ");
        int valor = lector.numeroPorTeclado();
        return new Numero(valor);
    }
}