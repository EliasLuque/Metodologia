static void llenar(Coleccionable coleccionable, int opcion)
{
    Random randNum = new Random();
    for (int i = 0; i < 20; i++)
    {
        Comparable comparable = FabricaDeComparables.crearAleatorio(opcion);
        coleccionable.agregar(comparable);
    }
}

static void informar(Coleccionable coleccionable, int opcion)
{
    Console.WriteLine("Cantidad de elementos: {0}", coleccionable.cuantos());
    Console.WriteLine("Elemento Mínimo: {0}", coleccionable.minimo().ToString());
    Console.WriteLine("Elemento Máximo: {0}", coleccionable.maximo().ToString());

    Comparable comparable = FabricaDeComparables.crearPorTeclado(opcion);
    if (coleccionable.contiene(comparable))
    {
        Console.WriteLine("El elemento leído está en la colección.");
    }
    else
    {
        Console.WriteLine("El elemento leído no está en la colección.");
    }
}

static void imprimirElementos(Coleccionable c)
{
    Iterador i = c.crearIterador();

    while (!i.fin())
    {
        Console.WriteLine(((Alumno)i.actual()).ToString());
        i.siguiente();
    }
}

static void cambiarEstrategia(Coleccionable c, EstrategiaDeComparacion e)
{
    Iterador i = c.crearIterador();

    while (!i.fin())
    {
        ((Alumno)i.actual()).cambiarEstrategia(e);
        i.siguiente();
    }
}

const int ALUMNO = 1;
const int NUMERO = 2;
const int PROFESOR = 3;

Pila<Comparable> pila = new Pila<Comparable>();

llenar(pila, PROFESOR);
informar(pila, PROFESOR);

Console.ReadKey();