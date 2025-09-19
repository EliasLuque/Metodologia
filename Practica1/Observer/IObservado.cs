public interface IObservado
{
    void agregarObservador(IObservador observador);
    void quitarObservador(IObservador observador);
    void notificar();
}