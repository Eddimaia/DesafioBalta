using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DesafioBalta.Models
{
    public class Premium
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o título.")]
        [StringLength(80, ErrorMessage = "O título deve conter no máximo 80 caracteres.")]
        [MinLength(5, ErrorMessage = "O título deve conter pelo menos 5 caracteres.")]
        [DisplayName("Título Completo")]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        [DisplayName("Inicio")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Término")]
        public DateTime EndDate { get; set; }

        [DisplayName("Aluno")]
        [Required(ErrorMessage = "Aluno Inválido")]
        public int StudentId { get; set; }

        public Student? Student { get; set; }
    }
}
