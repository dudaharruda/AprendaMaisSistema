using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AprendaMaisSistema.Models
{
    [Table("Professores")]
    public class Professores
    {
        [Column("ProfessoresId")]
        [Display(Name = "Código do Professor")]
        public int ProfessoresId { get; set; }

        [Column("NomeProfessores")]
        [Display(Name = "Nome dos Professores")]
        public string NomeProfessores { get; set; } = string.Empty;
    }
}
