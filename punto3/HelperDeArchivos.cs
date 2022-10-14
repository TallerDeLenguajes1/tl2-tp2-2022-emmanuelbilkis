namespace Instituto{
    

static class HelperDeArchivos
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
    public static void escribirCSV(List<Alumno> alumnos)
    {
        foreach (var alum in alumnos)
        {
            switch (alum.Curso)
            {
                case 1 : 
                  try
                  {
                            Logger.Info("Se crea el archivo Atletismo.csv");
                            FileStream miArchivo = new FileStream("Atletismo" + ".csv", FileMode.OpenOrCreate);

                            using (StreamWriter strwriter = new StreamWriter(miArchivo))
                            { 
                              strwriter.WriteLine("{0},{2},{3}",alum.getNombre(),alum.getApe(),alum.getDNI());  
                              strwriter.Close();   
                            }
                  } 
                   catch (FileNotFoundException e)
                    {
                        Logger.Error($"El archivo no se encontro: '{e}'");
                    }
                    catch (DirectoryNotFoundException e)
                    {
                        Logger.Error($"El directorio no se encontro: '{e}'");
                    }
                    catch (IOException e)
                    {
                        Logger.Error($"No se pudo abrir el archivo: '{e}'");
                    }
                    catch(NullReferenceException e)
                    {
                      Logger.Error($" Ha olvidado crear una instancia de un tipo de referencia: '{e}'");
                    }
                    
                            
                break;

                case 2:
                    try
                    {
                        Logger.Info("Se crea el archivo Voley.csv");
                      FileStream miArchivo2 = new FileStream("Voley" + ".csv", FileMode.OpenOrCreate);

                            using (StreamWriter strwriter = new StreamWriter(miArchivo2))
                            { 
                              strwriter.WriteLine("{0},{2},{3}",alum.getNombre(),alum.getApe(),alum.getDNI());  
                              strwriter.Close();   
                            }
                    }
                    catch (FileNotFoundException e)
                    {
                        Logger.Error($"El archivo no se encontro: '{e}'");
                    }
                    catch (DirectoryNotFoundException e)
                    {
                        Logger.Error($"El directorio no se encontro: '{e}'");
                    }
                    catch (IOException e)
                    {
                        Logger.Error($"No se pudo abrir el archivo: '{e}'");
                    }
                    catch(NullReferenceException e)
                    {
                      Logger.Error($" Ha olvidado crear una instancia de un tipo de referencia: '{e}'");
                    }
                      
                            
                     break;

                case 3:
                      try
                      {
                        Logger.Info("Se crea el archivo Futbol.csv");
                        FileStream miArchivo3 = new FileStream("Futbol" + ".csv", FileMode.OpenOrCreate);

                            using (StreamWriter strwriter = new StreamWriter(miArchivo3))
                            { 
                              strwriter.WriteLine("{0},{2},{3}",alum.getNombre(),alum.getApe(),alum.getDNI());  
                              strwriter.Close();   
                            }
                      }
                      catch (FileNotFoundException e)
                      {
                          Logger.Error($"El archivo no se encontro: '{e}'");
                      }
                      catch (DirectoryNotFoundException e)
                      {
                          Logger.Error($"El directorio no se encontro: '{e}'");
                      }
                      catch (IOException e)
                      {
                          Logger.Error($"No se pudo abrir el archivo: '{e}'");
                      }
                      catch(NullReferenceException e)
                      {
                        Logger.Fatal($" Ha olvidado crear una instancia de un tipo de referencia: '{e}'");
                      }
                      
                            
                      break;
                      default:
                            throw new ArgumentException(String.Format($"{0} is not an even number", alum.Curso),
                                      "num");
            }
        }       
    }

     public static void limpiar(string nombreArchivo){

        try
        {
          File.Delete(nombreArchivo);
        }
          catch (FileNotFoundException e)
                      {
                          Console.WriteLine($"El archivo no se encontro: '{e}'");
                      }
                      catch (DirectoryNotFoundException e)
                      {
                          Console.WriteLine($"El directorio no se encontro: '{e}'");
                      }
                      catch (IOException e)
                      {
                          Console.WriteLine($"No se pudo abrir el archivo: '{e}'");
                      }
     }
}

}
/*
public class EHClass
{
    void ReadFile(int index)
    {
        // To run this code, substitute a valid path from your local machine
        string path = @"c:\users\public\test.txt";
        System.IO.StreamReader file = new System.IO.StreamReader(path);
        char[] buffer = new char[10];
        try
        {
            file.ReadBlock(buffer, index, buffer.Length);
        }
        catch (System.IO.IOException e)
        {
            Console.WriteLine("Error reading from {0}. Message = {1}", path, e.Message);
        }
        finally
        {
            if (file != null)
            {
                file.Close();
            }
        }
        // Do something with buffer...
    }
}

*/