using System.Text;

public class DecoradoConAsteriscos : AlumnoDecorator
{
    public DecoradoConAsteriscos(IAlumno alumno) : base(alumno)
    { }

    public override string mostrarCalificacion()
    {
        StringBuilder texto = new StringBuilder();
        texto.Append(base.mostrarCalificacion());

        // Agregando margenes izquierdo y derecho
        texto.Insert(0, "*\t");
        texto.Append("\t*\n");

        // Creando y agregando margenes superior e inferior
        string margen = "";
        for (int i = 1; i < 50; i++)
        {
            margen += "*";
        }
        texto.Insert(0, margen + "\n");
        texto.Append(margen);

        return texto.ToString();
    }
}