using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarApplication.Models
{
    [Table("Roles")]
    public class Roles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AccessRights { get; set; }
    }
}
