public class Numero : Comparable
{
    // Atributos
    private int valor;

    // Contructor
    public Numero(int v)
    {
        this.valor = v;
    }

    // Métodos
    public int getValor() => this.valor;

    // Interface Comparable
    public bool sosIgual(Comparable c) => this.valor == ((Numero)c).getValor();
    public bool sosMenor(Comparable c) => this.valor < ((Numero)c).getValor();
    public bool sosMayor(Comparable c) => this.valor > ((Numero)c).getValor();
}