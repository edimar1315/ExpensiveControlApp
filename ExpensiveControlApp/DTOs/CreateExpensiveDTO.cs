using System.ComponentModel.DataAnnotations;

namespace ExpensiveControlApp.DTOs
{
    public class CreateExpensiveDTO
    {
        public CreateExpensiveDTO()
        {
            Date = DateTime.Now;
        }

        [Required(ErrorMessage = "Descrição é obrigatória.")]                 
        public string Description { get; set; }

        //[Required(ErrorMessage = "Descrição é obrigatória.")]  

        [Required(ErrorMessage = "Valor é obrigatorio.")]
        [Range(0.01, 99999999999, ErrorMessage = "Valor deve ser maior que 0.")]
        public double Value { get; set; }

        [Required(ErrorMessage = "Data é obrigatória.")]
        public DateTime Date { get; set; }


    }
}
