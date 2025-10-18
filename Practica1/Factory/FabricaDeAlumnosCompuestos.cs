public class FabricaDeAlumnosCompuestos : FabricaDeComparables
{
    public override Comparable crearAleatorio()
    {
        AlumnoCompuesto alumno = new AlumnoCompuesto();
        for(int i = 0; i < 5; i++)
        {
            string n = generador.stringAleatorio(5);
            alumno.agregarHijo(new AlumnoProxy(n));
        }
        return alumno;
    }

    public override Comparable crearPorTeclado()
    {
        AlumnoCompuesto alumno = new AlumnoCompuesto();
        for(int i = 0; i < 5; i++)
        {
            Console.Write("Nombre: ");
            string n = lector.stringPorTeclado();
            alumno.agregarHijo(new AlumnoProxy(n));
        }
        return alumno;
    }
}