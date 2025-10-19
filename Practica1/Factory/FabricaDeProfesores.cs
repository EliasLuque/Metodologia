public class FabricaDeProfesores : FabricaDeComparables
{
    public override Comparable crearAleatorio()
    {
        string n = obtencionDeDatos.stringAleatorio(5);
        int d = obtencionDeDatos.numeroAleatorio(10000000);
        int a = obtencionDeDatos.numeroAleatorio(10);
        return new Profesor(n, d, a);
    }

    public override Comparable crearPorArchivo()
    {
        string n = obtencionDeDatos.stringDesdeArchivo(5);
        int d = (int)obtencionDeDatos.numeroDesdeArchivo(10000000);
        int a = (int)obtencionDeDatos.numeroDesdeArchivo(10);
        return new Profesor(n, d, a);
    }

    public override Comparable crearPorTeclado()
    {
        Console.WriteLine("Ingrese los siguientes datos");
       
        Console.Write("Nombre: ");
        string n = obtencionDeDatos.stringPorTeclado();

        Console.Write("DNI: ");
        int d = obtencionDeDatos.numeroPorTeclado();

        Console.Write("Antigüedad: ");
        int a = obtencionDeDatos.numeroPorTeclado();

        return new Profesor(n, d, a);
    }
}