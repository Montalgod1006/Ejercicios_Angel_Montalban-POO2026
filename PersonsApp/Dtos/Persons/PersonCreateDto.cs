
using System.ComponentModel.DataAnnotations;

namespace PersonsApp.Dtos.Persons
{
    public class PersonCreateDto
    {
        [Required(ErrorMessage ="El DNI es requerido")] //ctrl + .
        [StringLength(13, ErrorMessage ="El DNI debe tener 13 dígitos.", MinimumLength = 13)]
        public string DNI { get; set; }

        [Display(Name = "Nombres")]
        [Required(ErrorMessage ="Los {0} son requeridos.")]
        [StringLength(40, ErrorMessage = "Los {0} deben tener un mínimo de {2} y máximo de {1} caracteres", MinimumLength = 3)]//El nombre es la posicion 0, el maximo 1 y el minimo 2
        public string FirstName { get; set; }
        [Display(Name = "Apellidos")]
        [Required(ErrorMessage ="Los {0} son requeridos.")]
        [StringLength(40, ErrorMessage = "Los {0} deben tener un mínimo de {2} y máximo de {1} caracteres", MinimumLength = 3)]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string  Gender { get; set; }

        [Display(Name = "País")]
        [Required(ErrorMessage ="El{0} es requerido")]
        //[StringLength(50, ErrorMessage = "El {0} debe tener un mínimo{2} y máximo de {1}", MinimumLength = 3)]
        public string CountryId { get; set; }
        //ToDo: agregar validación de GUID

    }
}