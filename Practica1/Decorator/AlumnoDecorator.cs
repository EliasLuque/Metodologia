abstract public class AlumnoDecorator : IAlumno
{
    IAlumno alumno;

    public AlumnoDecorator(IAlumno alumno)
    {
        this.alumno = alumno;
    }

    public string getNombre() => alumno.getNombre();

    public string mostrarCalificacion() => alumno.mostrarCalificacion();

    public int responderPregunta(int pregunta) => alumno.responderPregunta(pregunta);

    public void setCalificacion(int cal) => alumno.setCalificacion(cal);

    public bool sosIgual(Comparable c) => alumno.sosIgual(c);

    public bool sosMayor(Comparable c) => alumno.sosMayor(c);

    public bool sosMenor(Comparable c) => alumno.sosMenor(c);
}