public class IteradorDeComparables : Iterador
{
    int paginaActual;
    Coleccionable coleccionable;

    public IteradorDeComparables(Coleccionable c)
    {
        this.coleccionable = c;
        primero();
    }
    public Comparable actual() => coleccionable.obtener(paginaActual);

    public bool fin() => paginaActual >= coleccionable.cuantos();

    public void primero() => paginaActual = 0;

    public void siguiente() => this.paginaActual += 1;
}