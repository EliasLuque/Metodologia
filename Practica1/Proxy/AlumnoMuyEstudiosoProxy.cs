public class AlumnoMuyEstudiosoProxy : IAlumno
{
    AlumnoMuyEstudioso? alumno = null;
    string nombre;

    public AlumnoMuyEstudiosoProxy(string nombre)
    {
        this.nombre = nombre;
    }

    private void crearAlumnoReal()
    {
        if (alumno == null)
        {
            alumno = (AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(4);
            alumno.setNombre(this.nombre);
        }
    }

    public int getCalificacion()
    {
        crearAlumnoReal();
        return alumno.getCalificacion();
    }

    public int getLegajo()
    {
        crearAlumnoReal();
        return alumno.getLegajo();
    }

    public string getNombre()
    {
        if (alumno == null)
        {
            return this.nombre;
        }
        else
        {
            return alumno.getNombre();
        }
    }

    public string mostrarCalificacion()
    {
        crearAlumnoReal();
        return alumno.mostrarCalificacion();
    }

    public int responderPregunta(int pregunta)
    {
        crearAlumnoReal();
        return alumno.responderPregunta(pregunta);
    }

    public void setCalificacion(int cal)
    {
        crearAlumnoReal();
        alumno.setCalificacion(cal);
    }

    public bool sosIgual(Comparable c)
    {
        crearAlumnoReal();
        return alumno.sosIgual(c);
    }

    public bool sosMayor(Comparable c)
    {
        crearAlumnoReal();
        return alumno.sosMayor(c);
    }

    public bool sosMenor(Comparable c)
    {
        crearAlumnoReal();
        return alumno.sosMenor(c);
    }
}