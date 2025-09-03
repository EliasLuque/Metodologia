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
    Random randNombre = new Random();
    Random randDni = new Random();
    Random randLegajo = new Random();
    Random randPromedio = new Random();

    for (int i = 0; i < 20; i++)
    {
        string nombre = nombres[randNombre.Next(50)];
        int dni = randDni.Next(10000000, 50000000);
        int legajo = randLegajo.Next(10000);
        double promedio = Math.Round(randPromedio.NextDouble() * 10, 2);

        Comparable alumno = new Alumno(nombre, dni, legajo, promedio);
        // Ejercicio 2
        ((Alumno)alumno).cambiarEstrategia(new ComparacionPorNombre());
        c.agregar(alumno);
    }
}
Pila<Comparable> pila = new Pila<Comparable>();
Cola<Comparable> cola = new Cola<Comparable>();
ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

llenarAlumnos(pila);
llenarAlumnos(cola);

// informar(pila);
// Console.WriteLine();
// informar(cola);
// Console.WriteLine();
informar(multiple);

Console.ReadKey();