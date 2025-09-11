static void llenar(Coleccionable c)
{
    Random randNum = new Random();
    for (int i = 0; i < 20; i++)
    {
        Comparable numero = new Numero(randNum.Next(1,50));
        c.agregar(numero);
    }
}

static void informar(Coleccionable c)
{
    Console.WriteLine("Cantidad de elementos: {0}", c.cuantos());
    Console.WriteLine("Elemento Mínimo: {0}", c.minimo().ToString());
    Console.WriteLine("Elemento Máximo: {0}", c.maximo().ToString());

    // Console.Write("Ingrese un valor: ");
    // int elem = int.Parse(Console.ReadLine());
    // Comparable numero = new Numero(elem);

    // if (c.contiene(numero))
    // {
    //     Console.WriteLine("El elemento leído está en la colección");
    // }
    // else
    // {
    //     Console.WriteLine("El elemento leído no está en la colección");
    // }
}

static void llenarAlumnos(Coleccionable c)
{
    string[] nombres = ["Alejandro", "Mateo", "Diego", "Luis", "Juan", "Andrés", "Sebastián", "Carlos", "Tomás", "Gabriel", "Martín", "Bruno", "Nicolás", "Emiliano", "Rodrigo", "Santiago", "Miguel", "Daniel", "Joaquín", "Lucas", "Valentina", "Sofía", "Camila", "Isabella", "Mariana", "Ana", "Lucía", "Daniela", "Paula", "Julieta", "Martina", "Carla", "Gabriela", "Elena", "Sara", "Laura", "Ángela", "Renata", "Zoe", "Jimena", "Alex", "Sam", "Cris", "Dani", "Ariel", "Noa", "Isa", "Andy", "Robin", "Taylor"];
    Random randNum = new Random();

    for (int i = 0; i < 20; i++)
    {
        string nombre = nombres[randNum.Next(50)];
        int dni = randNum.Next(10000000, 50000000);
        int legajo = randNum.Next(10000);
        double promedio = Math.Round(randNum.NextDouble() * 10, 2);

        Comparable alumno = new Alumno(nombre, dni, legajo, promedio);
        ((Alumno)alumno).cambiarEstrategia(new ComparacionPorNombre());
        c.agregar(alumno);
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

Pila<Comparable> pila = new Pila<Comparable>();
// Cola<Comparable> cola = new Cola<Comparable>();
// Conjunto<Comparable> conjunto = new Conjunto<Comparable>();
//ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

llenarAlumnos(pila);
// llenarAlumnos(cola);
// llenarAlumnos(conjunto);

// informar(pila);
// Console.WriteLine();
// informar(cola);
// Console.WriteLine();
// informar(multiple);

// Console.WriteLine("\nImprimiendo Pila");
// imprimirElementos(pila);
// Console.WriteLine("\nImprimiendo Cola");
// imprimirElementos(cola);
// Console.WriteLine("\nImprimiendo Conjunto");
// imprimirElementos(conjunto);

Console.WriteLine("Estrategia por Nombre: ");
cambiarEstrategia(pila, new ComparacionPorNombre());
informar(pila);
Console.WriteLine();

Console.WriteLine("Estrategia por Legajo: ");
cambiarEstrategia(pila, new ComparacionPorLegajo());
informar(pila);
Console.WriteLine();

Console.WriteLine("Estrategia por Promedio: ");
cambiarEstrategia(pila, new ComparacionPorPromedio());
informar(pila);
Console.WriteLine();

Console.WriteLine("Estrategia por DNI: ");
cambiarEstrategia(pila, new ComparacionPorDni());
informar(pila);
Console.WriteLine();


Console.ReadKey();