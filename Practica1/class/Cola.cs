public class Cola<T> : Coleccionable, Iterable, Ordenable
{
    private List<T> cola;
    private OrdenEnAula1? ordenInicio;
    private OrdenEnAula1? ordenAulaLlena;
    private OrdenEnAula2? ordenLlegaAlumno;
    public Cola()
    {
        this.cola = new List<T>();
    }

    // Métodos
    public T desencolar()
    {
        T tope = this.cola[0];
        this.cola.RemoveAt(0);
        return tope;
    } 

    // Interface
    public int cuantos() => this.cola.Count();

    public void agregar(Comparable c)
    {
        cola.Add((T)c);
        
        int cuantos = this.cuantos();
        if (cuantos == 1) { ordenInicio.ejecutar(); }

        ordenLlegaAlumno.ejecutar(c);

        if (cuantos == 40)
        {
            ordenAulaLlena.ejecutar();
        }
    }

    public Comparable obtener(int i) => (Comparable)this.cola[i];
    public bool contiene(Comparable c)
    {
        bool flag = false;
        foreach (T elem in this.cola)
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
        T max = this.cola[0];
        foreach (T elem in this.cola)
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
        T min = this.cola[0];
        foreach (T elem in this.cola)
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