public static class Program
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    public static void Main()
    {
        try
        {
           Logger.Info("Hello world");
           Logger.Info("Hello {Name}", "Earth");
           Logger.Debug("Holaa");
           System.Console.ReadKey();
        }
        catch (Exception ex)
        {
           Logger.Error(ex, "Goodbye cruel world");
        }
    }
}  

/*
namespace MyNamespace
{
  public class MyClass
  {
    private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
  }
}




public static void guardarGanadoresCSV(string nombre, string extension, List<Personaje> ganadores)
    {

            FileStream miArchivo = new FileStream(nombre + extension, FileMode.OpenOrCreate);

            using (StreamWriter strwriter = new StreamWriter(miArchivo))
            {

                    foreach (var ganadorX in ganadores)
                    {
                        strwriter.WriteLine("{0},{2},{3}", ganadorX.Nombre, ganadorX.Edad, ganadorX.Nacimiento);    
                    }

                    strwriter.Close();   
            }  
    }

    public static void MostrarGanadoresCSV(string nombre, string extension)
    {

            FileStream miArchivo = new FileStream(nombre + extension, FileMode.Open);

            using (StreamReader strread = new StreamReader(miArchivo))
            {

                    string ganadores = strread.ReadToEnd();
                    Console.WriteLine(ganadores);
                    strread.Close();   
            }  
    }


    
public static void incorporarAlumnosFutbol(string nombre, string extension, List<Personaje> ganadores)
    {

            FileStream miArchivo = new FileStream(nombre + extension, FileMode.OpenOrCreate);

            using (StreamWriter strwriter = new StreamWriter(miArchivo))
            {

                    foreach (var ganadorX in ganadores)
                    {
                        strwriter.WriteLine("{0},{2},{3}", ganadorX.Nombre, ganadorX.Edad, ganadorX.Nacimiento);    
                    }

                    strwriter.Close();   
            }  
    }

    
*/