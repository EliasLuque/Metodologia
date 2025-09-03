public class ComparacionPorNombre : EstrategiaDeComparacion
{
    public bool sosIgual(Alumno a1, Alumno a2) => string.Compare(a1.getNombre(), a2.getNombre()) == 0;
    public bool sosMenor(Alumno a1, Alumno a2) => string.Compare(a1.getNombre(), a2.getNombre()) < 0;
    public bool sosMayor(Alumno a1, Alumno a2) => string.Compare(a1.getNombre(), a2.getNombre()) > 0;
}