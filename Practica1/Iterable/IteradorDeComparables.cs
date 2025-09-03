public class IteradorDeComparables : Iterador
{
    int indice;
    Coleccionable coleccionable;

    public IteradorDeComparables(Coleccionable c)
    {
        this.coleccionable = c;
        primero();
    }
    public Comparable actual() => coleccionable.obtener(indice);

    public bool fin() => indice >= coleccionable.cuantos();

    public void primero() => indice = 0;

    public void siguiente() => this.indice += 1;
}