public class AlumnoCompuesto : IAlumno, Comparable
{
    List<IAlumno> hijos;

    public AlumnoCompuesto()
    {
        this.hijos = new List<IAlumno>();
    }

    public void agregarHijo(IAlumno alumno) => this.hijos.Add(alumno);
    public void quitarHijo(IAlumno alumno) => this.hijos.Remove(alumno);

    public string getNombre()
    {
        string nombres = "";
        foreach (IAlumno hijo in this.hijos)
        {
            nombres += hijo.getNombre() + "\n";
        }
        return nombres;
    }

    public string mostrarCalificacion()
    {
        string calificaciones = "";
        foreach (IAlumno hijo in this.hijos)
        {
            calificaciones += hijo.mostrarCalificacion() + "\n";
        }
        return calificaciones;
    }

    public int responderPregunta(int pregunta)
    {
        int[] contadorRespuestas = [0, 0, 0];

        foreach (IAlumno hijo in this.hijos)
        {
            int respuesta = hijo.responderPregunta(pregunta);
            switch (respuesta)
            {
                case 0:
                    contadorRespuestas[0]++;
                    break;
                case 1:
                    contadorRespuestas[1]++;
                    break;
                case 2:
                    contadorRespuestas[2]++;
                    break;
            }
        }

        int indice = 0;
        int max = contadorRespuestas[0];
        for (int i = 0; i < contadorRespuestas.Count(); i++)
        {
            if (max < contadorRespuestas[i])
            {
                max = contadorRespuestas[i];
                indice = i;
            }
        }
        return indice;
    }

    public void setCalificacion(int cal)
    {
        foreach (IAlumno hijo in this.hijos)
        {
            hijo.setCalificacion(cal);
        }
    }

    public bool sosIgual(Comparable c)
    {
        bool flag = false;
        foreach (IAlumno hijo in this.hijos)
        {
            if (hijo.sosIgual(c))
            {
                flag = true;
            }
        }
        return flag;
    }

    public bool sosMayor(Comparable c)
    {
        bool flag = true;
        foreach (IAlumno hijo in this.hijos)
        {
            if (!hijo.sosMayor(c))
            {
                flag = false;
            }
        }
        return flag;
    }

    public bool sosMenor(Comparable c)
    {
        bool flag = true;
        foreach (IAlumno hijo in this.hijos)
        {
            if (!hijo.sosMenor(c))
            {
                flag = false;
            }
        }
        return flag;
    }

    public int getLegajo()
    {
        throw new NotImplementedException();
    }

    public int getCalificacion()
    {
        throw new NotImplementedException();
    }
}