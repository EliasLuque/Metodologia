public abstract class FabricaDeComparables
{
    private const int ALUMNO = 1;
    private const int NUMERO = 2;
    private const int PROFESOR = 3;
    private const int ALUMNOMUYESTUDIOSO = 4;
    private const int ALUMNOCOMPUESTO = 5;
    protected GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
    protected LectorDeDatos lector = new LectorDeDatos();

    public abstract Comparable crearAleatorio();
    public static Comparable crearAleatorio(int opcion)
    {
        FabricaDeComparables fabrica = null;

        switch (opcion)
        {
            case ALUMNO:
                fabrica = new FabricaDeAlumnos();
                break;
            case NUMERO:
                fabrica = new FabricaDeNumeros();
                break;
            case PROFESOR:
                fabrica = new FabricaDeProfesores();
                break;
            case ALUMNOMUYESTUDIOSO:
                fabrica = new FabricaDeAlumnosMuyEstudiosos();
                break;
            case ALUMNOCOMPUESTO:
                fabrica = new FabricaDeAlumnosCompuestos();
                break;
        }
        return fabrica.crearAleatorio();
    }

    public abstract Comparable crearPorTeclado();
    public static Comparable crearPorTeclado(int opcion)
    {
        FabricaDeComparables fabrica = null;

        switch (opcion)
        {
            case ALUMNO:
                fabrica = new FabricaDeAlumnos();
                break;
            case NUMERO:
                fabrica = new FabricaDeNumeros();
                break;
            case PROFESOR:
                fabrica = new FabricaDeProfesores();
                break;
            case ALUMNOMUYESTUDIOSO:
                fabrica = new FabricaDeAlumnosMuyEstudiosos();
                break;
            case ALUMNOCOMPUESTO:
                fabrica = new FabricaDeAlumnosCompuestos();
                break;
        }
        return fabrica.crearPorTeclado();
    }
}