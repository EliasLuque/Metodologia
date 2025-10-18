public class ComparacionPorPuntaje : EstrategiaDeComparacion
{
    public bool sosIgual(Comparable c1, Comparable c2) => ((Jugador)c1).getPuntos() == ((Jugador)c2).getPuntos();
    public bool sosMenor(Comparable c1, Comparable c2) => ((Jugador)c1).getPuntos() < ((Jugador)c2).getPuntos();
    public bool sosMayor(Comparable c1, Comparable c2) => ((Jugador)c1).getPuntos() > ((Jugador)c2).getPuntos();
}