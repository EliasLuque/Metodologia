public class LectorDeDatos: Manejador
{
    public LectorDeDatos(Manejador sucesor) : base(sucesor)
    { }

    override public int numeroPorTeclado() => int.Parse(Console.ReadLine());
    override public string stringPorTeclado() => Console.ReadLine();
}