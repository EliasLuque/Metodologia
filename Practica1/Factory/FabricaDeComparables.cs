public abstract class FabricaDeComparables
{
    public static Comparable crearAleatorio(int opcion)
    {
        Comparable comparable;
        GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();

        switch (opcion)
        {
            case 1:
                string n = generador.stringAleatorio(5);
                int d = generador.numeroAleatorio(10000000);
                int l = generador.numeroAleatorio(5000);
                double p = generador.numeroAleatorio(10);
                comparable = new Alumno(n, d, l, p);
                break;
            case 2:
                int valor = generador.numeroAleatorio(50);
                comparable = new Numero(valor);
                break;
            default:
                comparable = null;
                break;
        }
        return comparable;
    }

    public static Comparable crearPorTeclado(int opcion)
    {
        Comparable comparable;
        LectorDeDatos lector = new LectorDeDatos();

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingrese los siguientes datos");
                Console.WriteLine("Nombre: ");
                string n = lector.stringPorTeclado();
                Console.WriteLine("DNI: ");
                int d = lector.numeroPorTeclado();
                Console.WriteLine("Legajo: ");
                int l = lector.numeroPorTeclado();
                Console.WriteLine("Promedio: ");
                double p = lector.numeroPorTeclado();
                comparable = new Alumno(n,d,l,p);
                break;
            case 2:
                Console.WriteLine("Ingrese el numero: ");
                int valor = lector.numeroPorTeclado();
                comparable = new Numero(valor);
                break;
            default:
                comparable = null;
                break;
        }
        return comparable;
    }
}