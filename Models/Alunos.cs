using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AprendaMaisSistema.Models
{
    [Table("Alunos")]
    public class Alunos
    {
        [Column("AlunosId")]
        [Display(Name = "Codigo dos Alunos")]
        public int AlunosId { get; set; }

        [Column("NomeAlunos")]
        [Display(Name = "Nome dos Alunos")]
        public string NomeAlunos { get; set; }

        [Column("EmailAlunos")]
        [Display(Name = "Email dos Alunos")]
        public string EmailAlunos { get; set; }

        [Column("FoneAlunos")]
        [Display(Name = "Fone dos Alunos")]
        public string FoneAlunos { get; set; }

        [Column("CpfAlunos")]
        [Display(Name = "Cpf dos Alunos")]
        public string CpfAlunos { get; set; }

        [Column("SexoAlunos")]
        [Display(Name = "Sexo dos Alunos")]
        public string SexoAlunos { get; set; }
    }
}
