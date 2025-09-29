using System.Text;

public class DecoradoConLetras : AlumnoDecorator
{
    public DecoradoConLetras(IAlumno alumno) : base(alumno)
    { }

    public override string mostrarCalificacion()
    {
        StringBuilder texto = new StringBuilder();
        texto.Append(base.mostrarCalificacion());

        switch (base.getCalificacion())
        {    
            case 0:
                texto.Replace("\t0", "\t0 (CERO)");
                break;    
            case 1:
                texto.Replace("\t1", "\t1 (UNO)");
                break;    
            case 2:
                texto.Replace("\t2", "\t2 (DOS)");
                break;    
            case 3:
                texto.Replace("\t3", "\t3 (TRES)");
                break;    
            case 4:
                texto.Replace("\t4", "\t4 (CUATRO)");
                break;    
            case 5:
                texto.Replace("\t5", "\t5 (CINCO)");
                break;    
            case 6:
                texto.Replace("\t6", "\t6 (SEIS)");
                break;    
            case 7:
                texto.Replace("\t7", "\t7 (SIETE)");
                break;    
            case 8:
                texto.Replace("\t8", "\t8 (OCHO)");
                break;    
            case 9:
                texto.Replace("\t9", "\t9 (NUEVE)");
                break;    
            case 10:
                texto.Replace("\t10", "\t10 (DIEZ)");
                break;    
        }
        return texto.ToString();
    }
}