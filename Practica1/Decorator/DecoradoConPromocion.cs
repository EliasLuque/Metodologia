using System.Text;

public class DecoradoConPromocion : AlumnoDecorator
{
    public DecoradoConPromocion(IAlumno alumno) : base(alumno)
    { }

    public override string mostrarCalificacion()
    {
        StringBuilder texto = new StringBuilder();
        texto.Append(base.mostrarCalificacion());
        int cal = base.getCalificacion();

        if (cal < 4)
        {
            texto.Replace($"\t{cal}", $"\t{cal} (DESAPROBADO)");
        }
        else if (cal > 4 && cal < 7)
        {
            texto.Replace($"\t{cal}", $"\t{cal} (APROBADO)");
        }
        else
        {
            texto.Replace($"\t{cal}", $"\t{cal} (PROMOCIÓN)");
        }

        return texto.ToString();
    }
}