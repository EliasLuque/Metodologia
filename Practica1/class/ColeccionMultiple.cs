public class ColeccionMultiple : Coleccionable
{
    Pila<Comparable> pila;
    Cola<Comparable> cola;

    public ColeccionMultiple(Pila<Comparable> p, Cola<Comparable> c)
    {
        pila = p;
        cola = c;
    }

    public void agregar(Comparable c)
    {
        return;
    }

    public bool contiene(Comparable c)
    {
        bool flag = false;
        if (cola.contiene(c) || pila.contiene(c))
        {
            flag = true;
        }
        return flag;
    }

    public Iterador crearIterador() => new IteradorDeComparables(this);

    public int cuantos() => cola.cuantos() + pila.cuantos();

    public Comparable maximo()
    {
        if (cola.maximo().sosMayor(pila.maximo()))
        {
            return cola.maximo();
        }
        else
        {
            return pila.maximo();
        }
    }

    public Comparable minimo()
    {
        if (cola.minimo().sosMenor(pila.minimo()))
        {
            return cola.minimo();
        }
        else
        {
            return pila.minimo();
        }
    }

    public Comparable obtener(int i)
    {
        throw new NotImplementedException();
    }
}