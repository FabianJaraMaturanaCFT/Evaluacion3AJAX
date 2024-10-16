namespace Evaluacion3AJAX.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaIngreso { get; set; }

        public DateTime FechaInicio { get; set; }
        public string Estado { get; set; }
        public int Responsable { get; set; }


        /*simula la devolución de una tarea*/
        public static Tarea CargarTarea()
        {
            return new Tarea
            {
                Id = 1,
                Descripcion = "1",
                FechaInicio = DateTime.Now,
                FechaIngreso = DateTime.Now,
                Estado = "Pendiente",
                Responsable = 5,
            };
        }

        /*simula la devolución de una lista de tareas*/

        public static List<Tarea> CargarTareas()
        {
            return new List<Tarea>
            {
                new Tarea
                {
                    Id = 1,
                    Descripcion = "1",
                    FechaInicio = DateTime.Now,
                    FechaIngreso = DateTime.Now,
                    Estado = "Pendiente",
                    Responsable = 5,
                },
                new Tarea
                {
                    Id = 2,
                    Descripcion = "2",
                    FechaInicio = DateTime.Now,
                    FechaIngreso = DateTime.Now,
                    Estado = "Pendiente",
                    Responsable = 5,
                },
                new Tarea
                {
                    Id = 3,
                    Descripcion = "3",
                    FechaInicio = DateTime.Now,
                    FechaIngreso = DateTime.Now,
                    Estado = "Pendiente",
                    Responsable = 5,
                },
                new Tarea
                {
                    Id = 4,
                    Descripcion = "4",
                    FechaInicio = DateTime.Now,
                    FechaIngreso = DateTime.Now,
                    Estado = "Pendiente",
                    Responsable = 5,
                },
                new Tarea
                {
                    Id = 5,
                    Descripcion = "5",
                    FechaInicio = DateTime.Now,
                    FechaIngreso = DateTime.Now,
                    Estado = "Pendiente",
                    Responsable = 5,
                }
            };
        }


    }

}
