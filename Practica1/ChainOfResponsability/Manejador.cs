public abstract class Manejador
{
    Manejador? sucesor = null;

    public Manejador(Manejador sucesor)
    {
        this.sucesor = sucesor;
    }
    virtual public int numeroAleatorio(int max)
    {
        if (sucesor != null)
        {
            return sucesor.numeroAleatorio(max);
        }
        return 0;
    }
    virtual public string stringAleatorio(int cantidad)
    {
        if (sucesor != null)
        {
            return sucesor.stringAleatorio(cantidad);
        }
        return "";
    }
    virtual public int numeroPorTeclado()
    {
        if (sucesor != null)
        {
            return sucesor.numeroPorTeclado();
        }
        return 0;
    }
    virtual public string stringPorTeclado()
    {
        if (sucesor != null)
        {
            return sucesor.stringPorTeclado();
        }
        return "";
    }
    virtual public double numeroDesdeArchivo(double max)
    {
        if (sucesor != null)
        {
            return sucesor.numeroDesdeArchivo(max);
        }
        return 0.00;
    }
    virtual public string stringDesdeArchivo(int cant)
    {
        if (sucesor != null)
        {
            return sucesor.stringDesdeArchivo(cant);
        }
        return "";
    }
}