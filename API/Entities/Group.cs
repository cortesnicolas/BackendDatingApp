using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Group
    {
        public Group()
        {
            
        }

        public Group(string name)
        {
            Name = name;
        }

        [Key]
        public string Name { get; set; }
        // Cuando creamos un grupo, automaticamente creamos una nueva lista de conexión
        public ICollection<Connection> Connections { get; set; } = new List<Connection>();
    }
}