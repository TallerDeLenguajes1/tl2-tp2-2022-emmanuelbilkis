using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instituto;

public static class Program
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    public static void Main()
    {
        
     
            try
            {
                Logger.Info("Se crea las instancias de personas");

                Alumno persona1 = new Alumno(20,"sdd","defr",234212,1);
                Alumno persona2 = new Alumno(20,"sdd","defr",234212,1);

                Alumno persona3 = new Alumno(20,"sdd","defr",234212,2);
                Alumno persona4 = new Alumno(20,"sdd","defr",234212,2);

                Alumno persona5 = new Alumno(20,"sdd","defr",234212,3);
               
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"Error:ingreso un argumento null - '{e.HelpLink}'");
                Logger.Error($"Error:ingreso un argumento null - '{e.HelpLink}'");
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Error:formato incorrecto del algun parametro para el constructor - '{e.HelpLink}'");
                Logger.Error($"Error:formato incorrecto del algun parametro para el constructor - '{e.HelpLink}'");
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
                Logger.Error(e.Message);
                
            }
            
    }
          
        
    
} 
