using System.Text;

public class GeneradorDeDatosAleatorios
{
    Random random;

    public GeneradorDeDatosAleatorios()
    {
        random = new Random();
    }
    public int numeroAleatorio(int maximo) => random.Next(maximo);

    public string stringAleatorio(int cantidad)
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