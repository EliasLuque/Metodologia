public class LectorDeDatos: Manejador
{
    private static LectorDeDatos lector = null;
    private LectorDeDatos(Manejador sucesor) : base(sucesor)
    { }

    public static LectorDeDatos getInstance(Manejador sucesor)
    {
        if (lector == null)
        {
            lector = new LectorDeDatos(sucesor);
        }
        return lector;
    }
    override public int numeroPorTeclado() => int.Parse(Console.ReadLine());
    override public string stringPorTeclado() => Console.ReadLine();
}