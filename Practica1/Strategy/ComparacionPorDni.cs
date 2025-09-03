public class ComparacionPorDni : EstrategiaDeComparacion
{
    public bool sosIgual(Alumno a1, Alumno a2) => a1.getDni() == a2.getDni();
    public bool sosMenor(Alumno a1, Alumno a2) => a1.getDni() < a2.getDni();
    public bool sosMayor(Alumno a1, Alumno a2) => a1.getDni() > a2.getDni();
}