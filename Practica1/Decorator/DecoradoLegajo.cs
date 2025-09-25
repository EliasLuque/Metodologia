public class DecoradoLegajo : AlumnoDecorator
{
    public DecoradoLegajo(IAlumno alumno) : base(alumno)
    { }
    public string mostrarCalificacion() => base.mostrarCalificacion();
    
}