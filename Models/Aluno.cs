﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace WEBMVC.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        enum Periodo { Diurno, Vespertino, Noturno }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório.")]
        [StringLength(35)]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo aniversário é obrigatório.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Aniversário")]
        public DateTime aniversario { get; set; }

        [Required(ErrorMessage = "Campo email é obrigatório.")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email inválido.")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name ="Curso")]
        public int cursoID { get; set; }
        [ForeignKey("cursoID")]

        public Curso curso { get; set; }

        [Required(ErrorMessage ="Campo periodo é obrigatório.")]
        [Display(Name ="Período")]
        public string periodo { get; set; }
    }
}
