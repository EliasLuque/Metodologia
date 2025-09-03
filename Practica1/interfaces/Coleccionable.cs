public interface Coleccionable
{
    public int cuantos();
    public Comparable minimo();
    public Comparable maximo();
    public void agregar(Comparable c);
    public bool contiene(Comparable c);
    public Comparable obtener(int i);
    public Iterador crearIterador();
}