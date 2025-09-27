abstract public class AlumnoDecorator : IAlumno
{
    IAlumno alumno;

    public AlumnoDecorator(IAlumno alumno)
    {
        this.alumno = alumno;
    }

    public int getCalificacion() => alumno.getCalificacion();

    public int getLegajo() => alumno.getLegajo();

    virtual public string getNombre() => alumno.getNombre();

    virtual public string mostrarCalificacion() => alumno.mostrarCalificacion();

    virtual public int responderPregunta(int pregunta) => alumno.responderPregunta(pregunta);

    virtual public void setCalificacion(int cal) => alumno.setCalificacion(cal);

    virtual public bool sosIgual(Comparable c) => alumno.sosIgual(c);

    virtual public bool sosMayor(Comparable c) => alumno.sosMayor(c);

    virtual public bool sosMenor(Comparable c) => alumno.sosMenor(c);
}