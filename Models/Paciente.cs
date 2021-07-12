using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabCMV.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo nome da clínica é obrigatorio")]
        [MaxLength(50)]
        [Display(Name ="Nome da Clínica")]
        public string NomeClinica { get; set; }

        [Required(ErrorMessage = "O campo nome do paciente é obrigatorio")]
        [MaxLength(50)]
        [Display(Name ="Nome do Paciente")]
        public string NomePaciente { get; set; }

        [Required(ErrorMessage = "O campo sobrenome do paciente é obrigatorio")]
        [MaxLength(50)]
        [Display(Name ="Sobrenome do Paciente")]
        public string SobrenomePaciente { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatorio")]
        [MaxLength(100)]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo data de recebimento é obrigatorio")]
        [DataType(DataType.Date)]
        [Display(Name ="Data de Recebimento")]
        public DateTime DataRecebido { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataEntregue { get; set; }
        [Display(Name ="Data de Entegue")]

        [Required(ErrorMessage = "O campo estado é obrigatorio")]
        public bool Estado { get; set; }

    }
}
