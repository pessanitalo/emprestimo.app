using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmprestimoApp.Models
{
    public class Emprestimo
    {
        [Key]
        public int Id { get; set; }
        public int ClienteId { get; set; }
        [DisplayName("Valor do Emprestimo")]
        public double ValorEmprestimo { get; set; }
        [DisplayName("Quantidade Parcelas")]
        public int QuantidadeParcelas { get; set; }
        [DisplayName("Valor da Parcela")]
        public double ValorDaParcela { get; set; }
        [DisplayName("Valor Total")]
        public double valorTotal { get; set; }
        [DisplayName("Id")]
        public Cliente Cliente { get; set; }

        public double ValorTotal(double valorEmprestimo)
        {
            return valorEmprestimo += valorEmprestimo * 0.39;
        }

        public double ValorParcela(double valorTotal, double qtdParcelas)
        {
            return valorTotal / qtdParcelas;
        }
    }
}
