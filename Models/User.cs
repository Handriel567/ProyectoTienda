namespace TiendaProyecto.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public bool Status { get; set; }
        public string IdentificationNumber { get; set; }

        // Constructor (opcional, si lo necesitas para inicializar)
        public User()
        {
           
        }
    }
}
