public class Pila<T> : Coleccionable
{
    List<T> pila;

    public Pila()
    {
        this.pila = new List<T>();
    }

    // Métodos
    public Comparable desapilar()    => (Comparable)this.pila[this.pila.Count - 1];

    // Interface
    public int cuantos() => this.pila.Count;

    public void agregar(Comparable c) => pila.Add((T)c);


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
}