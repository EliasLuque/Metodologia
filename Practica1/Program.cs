using MetodologíasDeProgramaciónI;
using ObtencionDeDatos;

static void llenar(Coleccionable coleccionable, int opcion)
{
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

static void dictadoDeClases(Profesor profesor)
{
    for (int i = 0; i < 5; i++)
    {
        profesor.hablarALaClase();
        profesor.escribirEnElPizarron();
    }
}

const int ALUMNO = 1;
const int NUMERO = 2;
const int PROFESOR = 3;
const int ALUMNOMUYESTUDIOSO = 4;
const int ALUMNOCOMPUESTO = 5;
const int JUGADOR = 6;

Manejador manejador = LectorDeDatos.getInstance(null);
manejador = GeneradorDeDatosAleatorios.getInstance(manejador);
manejador = new LectorDeArchivos(manejador);
FabricaDeComparables.setManejador(manejador);

// Jugador j1 = (Jugador)FabricaDeComparables.crearAleatorio(JUGADOR);
// Jugador j2 = (Jugador)FabricaDeComparables.crearAleatorio(JUGADOR);

// JuegoCartas juego = new Truco(j1,j2);
// juego.jugar();

Teacher teacher = new Teacher();
AlumnoAdapter adapter;
// creando Alumno aleatoriamente
for(int i = 0; i < 5; i++)
{
    Alumno alumno = (Alumno)FabricaDeComparables.crearAleatorio(ALUMNO);
    adapter = new AlumnoAdapter(alumno);
    teacher.goToClass(adapter);
}
// creando AlumnoMuyEstudioso por teclado
for (int i = 0; i < 2; i++)
{
    AlumnoMuyEstudioso alumnoMuyEstudioso = (AlumnoMuyEstudioso)FabricaDeComparables.crearPorTeclado(ALUMNOMUYESTUDIOSO);
    adapter = new AlumnoAdapter(alumnoMuyEstudioso);
    teacher.goToClass(adapter);
}
// creando AlumnoCompuesto por archivo
AlumnoCompuesto alumnoCompuesto = (AlumnoCompuesto)FabricaDeComparables.crearAleatorio(ALUMNOCOMPUESTO);
adapter = new AlumnoAdapter(alumnoCompuesto);
teacher.goToClass(adapter);

teacher.teachingAClass();

Console.ReadKey();