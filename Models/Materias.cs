using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AprendaMaisSistema.Models
{
    [Table("Materias")]
    public class Materias
    {
        [Column("MateriasId")]
        [Display(Name = "Código da Materia")]
        public int MateriasId { get; set; }

        [Column("NomeMaterias")]
        [Display(Name = "Nome das Materias")]
        public string NomeMaterias { get; set; } = string.Empty;
    }
}
