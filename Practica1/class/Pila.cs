public class Pila<T> : Coleccionable, Iterable, Ordenable
{
    private List<T> pila;
    private OrdenEnAula1? ordenInicio;
    private OrdenEnAula1? ordenAulaLlena;
    private OrdenEnAula2? ordenLlegaAlumno;

    public Pila()
    {
        this.pila = new List<T>();
    }

    // Métodos
    public T desapilar()
    {
        T tope = this.pila[this.pila.Count - 1];
        pila.RemoveAt(this.pila.Count - 1);
        return tope;
    }
    // Interface
    public int cuantos() => this.pila.Count();

    public void agregar(Comparable c)
    {
        pila.Add((T)c);

        int cuantos = this.cuantos();
        if (cuantos == 1) { ordenInicio.ejecutar(); }

        ordenLlegaAlumno.ejecutar(c);

        if (cuantos == 40)
        {
            ordenAulaLlena.ejecutar();
        }
    }

    public Comparable obtener(int i) => (Comparable)this.pila[i];

    public bool contiene(Comparable c)
    {
        bool flag = false;
        foreach (T elem in this.pila)
        {
            if (((Comparable)elem).sosIgual(c))
            {
                flag = true;
            }
        }
        return flag;
    }

    public Comparable maximo()
    {
        T max = this.pila[0];
        foreach (T elem in this.pila)
        {
            if (((Comparable)elem).sosMayor((Comparable)max))
            {
                max = elem;
            }
        }
        return (Comparable)max;
    }

    public Comparable minimo()
    {
        T min = this.pila[0];
        foreach (T elem in this.pila)
        {
            if (((Comparable)elem).sosMenor((Comparable)min))
            {
                min = elem;
            }
        }
        return (Comparable)min;
    }
    public Iterador crearIterador() => new IteradorDeComparables(this);

    public void setOrdenInicio(OrdenEnAula1 orden) => this.ordenInicio = orden;

    public void setOrdenLlegaAlumno(OrdenEnAula2 orden) => this.ordenLlegaAlumno = orden;

    public void setOrdenAulaLlena(OrdenEnAula1 orden) => this.ordenAulaLlena = orden;
}