public interface IAlumno
{
    public string getNombre();
    public void setCalificacion(int cal);
    public int responderPregunta(int pregunta);
    public string mostrarCalificacion();
    public bool sosIgual(Comparable c);
    public bool sosMayor(Comparable c);
    public bool sosMenor(Comparable c);
}