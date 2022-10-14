
namespace Instituto
{
class Alumno
{
            
        private int Id { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private int Dni { get; set; }
        public int Curso { get; set; }

        public Alumno(int id,string nombre,string ape,int dni,int curso){

            this.Id = id;
            this.Nombre=nombre;
            this.Apellido=ape;
            this.Curso = curso;
            this.Dni = dni;
        }

        public string getNombre(){
            
                return this.Nombre;   
        }

        public string? getApe(){
            return this.Apellido;
        }

        public int getDNI(){
            return this.Dni;
        }


  }    
}


//NullReferenceException = Excepción que se produce cuando se intenta desreferenciar un objeto null. por ejemplo nombre.lenght()

// Se produce una NullReferenceException excepción cuando se intenta acceder a un miembro en un tipo cuyo valor es null.

// 1) Ha olvidado crear una instancia de un tipo de referencia
// 2) Ha olvidado dimensionar una matriz antes de inicializarla.
// En el ejemplo siguiente, values se declara como una matriz de enteros, pero el número de elementos que contiene nunca se especifica. Por lo tanto, el intento de inicializar sus valores produjo una NullReferenceException excepción
