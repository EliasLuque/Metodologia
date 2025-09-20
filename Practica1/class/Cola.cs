public class Cola<T> : Coleccionable, Iterable
{
    List<T> cola;

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
    public int cuantos() => this.cola.Count;

    public void agregar(Comparable c) => cola.Add((T)c);

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
}