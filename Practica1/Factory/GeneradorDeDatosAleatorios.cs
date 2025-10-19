using System.Text;

public class GeneradorDeDatosAleatorios: Manejador
{
    private static Random? random;
    private static GeneradorDeDatosAleatorios generador = null;
    private GeneradorDeDatosAleatorios(Manejador sucesor) : base(sucesor)
    {
        random = new Random();
    }
    public static GeneradorDeDatosAleatorios getInstance(Manejador sucesor)
    {
        if (generador == null)
        {
            generador = new GeneradorDeDatosAleatorios(sucesor);
        }
        return generador;
    }
    override public int numeroAleatorio(int maximo) => random.Next(maximo);

    override public string stringAleatorio(int cantidad)
    {
        StringBuilder constructor = new StringBuilder();
        const string abecedario = "abcdefghijklmnñopqrstuvwxyz";
        for (int i = 0; i < cantidad; i++)
        {
            constructor.Append(abecedario[numeroAleatorio(abecedario.Length)]);
        }
        return constructor.ToString();
    }
}