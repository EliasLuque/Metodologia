using System.Text;

public class GeneradorDeDatosAleatorios: Manejador
{
    Random random;

    public GeneradorDeDatosAleatorios(Manejador sucesor) : base(sucesor)
    {
        random = new Random();
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