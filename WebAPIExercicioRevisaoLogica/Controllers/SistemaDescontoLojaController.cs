using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIExercicioRevisaoLogica.Controllers
{
    public class SistemaDescontoLojaController : Controller
    {
        [HttpPost("CalcularDescontoLoja")]
        public string CalcularDescontoLoja(double valorCompraCliente,
                                            string situacaoCadastroCliente)
        {
            // Declaração de variaveis
            double valorCompra, percentualDesconto, valorDesconto;
            string situacaoCadastro;

            // Entrada
            valorCompra = valorCompraCliente;
            situacaoCadastro = situacaoCadastroCliente;

            // Processamento
            if (valorCompra > 1000)
            {
                percentualDesconto = 0.15;
                valorDesconto = valorCompra*percentualDesconto;
            }
            else if ((valorCompra > 500) && (valorCompra <= 1000))
            {
                percentualDesconto = 0.10;
                valorDesconto = valorCompra*percentualDesconto;
            }
            else
            {
                percentualDesconto = 0.05;
                valorDesconto = valorCompra*percentualDesconto;
            } 
            if (situacaoCadastro == "SIM")
            {
                percentualDesconto = percentualDesconto + 0.05;
                valorDesconto = valorCompra * percentualDesconto;
            }


            return $"Percentual de Desconto: {Math.Round(percentualDesconto * 100,0)}%\r\n" +
                   $"Valor de Desconto: {Math.Round(valorDesconto)}\r\n" +
                   $"Valor final: $ {Math.Round(valorCompra - valorDesconto)}";
        }
    }
}
