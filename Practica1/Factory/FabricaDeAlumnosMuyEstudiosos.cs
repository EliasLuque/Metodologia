public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
{
    public override Comparable crearAleatorio()
    {
        string n = obtencionDeDatos.stringAleatorio(5);
        int d = obtencionDeDatos.numeroAleatorio(10000000);
        int l = obtencionDeDatos.numeroAleatorio(5000);
        double p = obtencionDeDatos.numeroAleatorio(10);
        return new AlumnoMuyEstudioso(n, d, l, p);
    }

    public override Comparable crearPorArchivo()
    {
        string n = obtencionDeDatos.stringDesdeArchivo(5);
        int d = (int)obtencionDeDatos.numeroDesdeArchivo(10000000);
        int l = (int)obtencionDeDatos.numeroDesdeArchivo(5000);
        double p = obtencionDeDatos.numeroDesdeArchivo(10);
        return new AlumnoMuyEstudioso(n, d, l, p);
    }

    public override Comparable crearPorTeclado()
    {
        Console.WriteLine("Ingrese los siguientes datos");
       
        Console.Write("Nombre: ");
        string n = obtencionDeDatos.stringPorTeclado();

        Console.Write("DNI: ");
        int d = obtencionDeDatos.numeroPorTeclado();

        Console.Write("Legajo: ");
        int l = obtencionDeDatos.numeroPorTeclado();

        Console.Write("Promedio: ");
        double p = obtencionDeDatos.numeroPorTeclado();

        return new AlumnoMuyEstudioso(n, d, l, p);
    }
}