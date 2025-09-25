public abstract class FabricaDeComparables
{
    public const int ALUMNO = 1;
    public const int NUMERO = 2;
    public const int PROFESOR = 3;
    public const int ALUMNOMUYESTUDIOSO = 4;
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
        }
        return fabrica.crearPorTeclado();
    }
}