using MetodologíasDeProgramaciónI;

public class Aula
{
    private Teacher? teacher;

    public void comenzar()
    {
        Console.WriteLine("La clase va a comenzar");
        teacher = new Teacher();
    }

    public void nuevoAlumno(IAlumno alumno)
    {
        AlumnoAdapter adapter = new AlumnoAdapter(alumno);
        teacher.goToClass(adapter);
    }

    public void claseLista()
    {
        teacher.teachingAClass();
    }
}