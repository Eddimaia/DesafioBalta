﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DesafioBalta.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome.")]
        [StringLength(80, ErrorMessage = "O nome deve conter no máximo 80 caracteres.")]
        [MinLength(5, ErrorMessage = "O nome deve conter pelo menos 5 caracteres.")]
        [DisplayName("Nome Completo")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o e-mail.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        [DisplayName("E-mail")]
        public string Email { get; set; } = string.Empty;
        public List<Premium> Premiums { get; set; } = new();
    }
}