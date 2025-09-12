public class ComparacionPorDni : EstrategiaDeComparacion
{
    public bool sosIgual(Comparable a1, Comparable a2) => ((Alumno)a1).getDni() == ((Alumno)a2).getDni();
    public bool sosMenor(Comparable a1, Comparable a2) => ((Alumno)a1).getDni() < ((Alumno)a2).getDni();
    public bool sosMayor(Comparable a1, Comparable a2) => ((Alumno)a1).getDni() > ((Alumno)a2).getDni();
}