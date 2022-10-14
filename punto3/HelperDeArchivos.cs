using Instituto;
static class HelperDeArchivos
{
    public static void escribirCSV(List<Alumno> alumnos)
    {
        foreach (var alum in alumnos)
        {
            switch (alum.Curso)
            {
                case 1 : 
                            FileStream miArchivo = new FileStream("Atletismo" + ".csv", FileMode.OpenOrCreate);

                            using (StreamWriter strwriter = new StreamWriter(miArchivo))
                            { 
                              strwriter.WriteLine("{0},{2},{3}",alum.getNombre(),alum.getApe(),alum.getDNI());  
                              strwriter.Close();   
                            }
                break;

                case 2:
                            FileStream miArchivo2 = new FileStream("Voley" + ".csv", FileMode.OpenOrCreate);

                            using (StreamWriter strwriter = new StreamWriter(miArchivo2))
                            { 
                              strwriter.WriteLine("{0},{2},{3}",alum.getNombre(),alum.getApe(),alum.getDNI());  
                              strwriter.Close();   
                            }
                break;

                case 3:
                            FileStream miArchivo3 = new FileStream("Futbol" + ".csv", FileMode.OpenOrCreate);

                            using (StreamWriter strwriter = new StreamWriter(miArchivo3))
                            { 
                              strwriter.WriteLine("{0},{2},{3}",alum.getNombre(),alum.getApe(),alum.getDNI());  
                              strwriter.Close();   
                            }
                break;
            }
        }       
    }

     public static void limpiar(string nombreArchivo){

        File.Delete(nombreArchivo);
     }


}