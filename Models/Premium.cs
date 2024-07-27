using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProjetoAssinatura.Models
{
    public class Premium
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o titulo do Premium")]
        [StringLength(80, ErrorMessage = "0 titulo deve conter até 80 caracteres")]
        [MinLength(5, ErrorMessage = "o titulo deve conter pelo menos 5 caracteres")]
        [DisplayName("Titulo")]
        public string Title { get; set; } = string.Empty; 

        [DataType(DataType.DateTime)]
        //[GreaterThanToday]
        [DisplayName("Inicio")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Termino")] 
        public DateTime Endate { get; set; }

        [DisplayName("Aluno")]
        [Required(ErrorMessage = "Altune inválido")]
        public int StudentId { get; set; }

        public Student? Student { get; set; }
    }
}
