public class Conjunto<T> : Coleccionable, Iterable
{
    List<T> conjunto;

    public Conjunto()
    {
        conjunto = new List<T>();
    }

    public int cuantos() => this.conjunto.Count();
    public void agregar(Comparable c) => conjunto.Add((T)c);
    public Comparable obtener(int i) => (Comparable)this.conjunto[i];
    public bool pertenece(Comparable c) => contiene(c);

    public bool contiene(Comparable c)
    {
        bool flag = false;
        foreach (T elem in this.conjunto)
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
        T max = this.conjunto[0];
        foreach (T elem in this.conjunto)
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
        T min = this.conjunto[0];
        foreach (T elem in this.conjunto)
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