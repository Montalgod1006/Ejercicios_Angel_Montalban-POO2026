using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonsApp.Entities
{
    [Table("persons")]
    public class PersonEntity : BaseEntity
    {
        [Required()]
        [StringLength(13)]
        public string DNI { get; set; }
        [Required()]
        [StringLength(40)]
        public string FirstName { get; set; }
        [Required()]
        [StringLength(40)]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string  Gender { get; set; }

    }
}