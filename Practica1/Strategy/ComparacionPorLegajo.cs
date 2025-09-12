public class ComparacionPorLegajo : EstrategiaDeComparacion
{
    public bool sosIgual(Comparable a1, Comparable a2) => ((Alumno)a1).getLegajo() == ((Alumno)a2).getLegajo();
    public bool sosMenor(Comparable a1, Comparable a2) => ((Alumno)a1).getLegajo() < ((Alumno)a2).getLegajo();
    public bool sosMayor(Comparable a1, Comparable a2) => ((Alumno)a1).getLegajo() > ((Alumno)a2).getLegajo();
}