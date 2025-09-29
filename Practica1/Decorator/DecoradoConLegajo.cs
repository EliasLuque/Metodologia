using System.Text;

public class DecoradoConLegajo : AlumnoDecorator
{
    public DecoradoConLegajo(IAlumno alumno) : base(alumno)
    { }
    override public string mostrarCalificacion()
    {
        StringBuilder texto = new StringBuilder();
        texto.Append(base.mostrarCalificacion());
        texto.Replace(base.getNombre(), $"{base.getNombre()} ({base.getLegajo()})");
        return texto.ToString();
    }
}