using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmprestimoApp.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Score { get; set; }
        [DisplayName("Saldo Total")]
        public double SaldoAtual { get; set; }
        public Emprestimo Emprestimo { get; set; }
    }
}
