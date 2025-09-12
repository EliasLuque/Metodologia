public class FabricaDeAlumnos : FabricaDeComparables
{
    public override Comparable crearAleatorio()
    {
        GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();

        string n = generador.stringAleatorio(5);
        int d = generador.numeroAleatorio(10000000);
        int l = generador.numeroAleatorio(5000);
        double p = generador.numeroAleatorio(10);
        return new Alumno(n, d, l, p);
    }

    public override Comparable crearPorTeclado()
    {
        LectorDeDatos lector = new LectorDeDatos();
        Console.WriteLine("Ingrese los siguientes datos");
       
        Console.Write("Nombre: ");
        string n = lector.stringPorTeclado();

        Console.Write("DNI: ");
        int d = lector.numeroPorTeclado();

        Console.Write("Legajo: ");
        int l = lector.numeroPorTeclado();

        Console.Write("Promedio: ");
        double p = lector.numeroPorTeclado();

        return new Alumno(n, d, l, p);
    }
}