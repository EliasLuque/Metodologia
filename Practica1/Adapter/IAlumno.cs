public interface IAlumno
{
    public string getNombre();
    public int getLegajo();
    public void setCalificacion(int cal);
    public int getCalificacion();
    public int responderPregunta(int pregunta);
    public string mostrarCalificacion();
    public bool sosIgual(Comparable c);
    public bool sosMayor(Comparable c);
    public bool sosMenor(Comparable c);
}