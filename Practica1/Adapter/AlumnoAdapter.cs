using System.Data.Common;
using MetodologíasDeProgramaciónI;

public class AlumnoAdapter : Student
{
    Alumno alumno;
    public AlumnoAdapter(Alumno alumno)
    {
        this.alumno = alumno;
    }
    public string getName() => alumno.getNombre();

    public int yourAnswerIs(int question) => alumno.responderPregunta(question);

    public void setScore(int score) => alumno.setCalificacion(score);

    public string showResult() => alumno.mostrarCalificacion();

    public bool equals(Student student) => string.Compare(student.getName(), alumno.getNombre()) == 0;

    public bool lessThan(Student student) => string.Compare(student.getName(), alumno.getNombre()) < 0;

    public bool greaterThan(Student student) => string.Compare(student.getName(), alumno.getNombre()) > 0;
}