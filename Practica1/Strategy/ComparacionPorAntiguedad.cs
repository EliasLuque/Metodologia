public class ComparacionPorAntiguedad : EstrategiaDeComparacion
{
    public bool sosIgual(Comparable p1, Comparable p2) => ((Profesor)p1).getAntiguedad() == ((Profesor)p2).getAntiguedad();

    public bool sosMayor(Comparable p1, Comparable p2) => ((Profesor)p1).getAntiguedad() > ((Profesor)p2).getAntiguedad();

    public bool sosMenor(Comparable p1, Comparable p2) => ((Profesor)p1).getAntiguedad() < ((Profesor)p2).getAntiguedad();
}