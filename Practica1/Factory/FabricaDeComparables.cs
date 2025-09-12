public abstract class FabricaDeComparables
{
    public const int ALUMNO = 1;
    public const int NUMERO = 2;

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
        }
        return fabrica.crearPorTeclado();
    }
}