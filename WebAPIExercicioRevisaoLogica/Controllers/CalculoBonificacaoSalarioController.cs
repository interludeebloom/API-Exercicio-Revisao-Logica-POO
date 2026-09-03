using Microsoft.AspNetCore.Mvc;

namespace WebAPIExercicioRevisaoLogica.Controllers
{
    public class CalculoBonificacaoSalarioController : Controller
    {
        [HttpPost("CalcularBonificacaoSalario")]
        public string CalcularBonificacaoSalario(double salarioFuncionario,
                                                 int tempoEmpresaSalario)
        {
            // Declaração de variaveis
            double salario, valorBonificacao, percentualDesconto;
            int tempoEmpresa;

            // Entrada
            salario = salarioFuncionario;
            tempoEmpresa = tempoEmpresaSalario;

            // Processamento
            if (salario < 2000)
            {
                percentualDesconto = 0.2;
                valorBonificacao = salario * percentualDesconto;
            } else if((salario >= 2000) && (salario < 5000))
            {
                percentualDesconto = 0.1;
                valorBonificacao = salario * percentualDesconto;
            }
            else
            {
                percentualDesconto = 0.05;
                valorBonificacao = salario * percentualDesconto;
            }
            if (tempoEmpresa > 10)
            {
                percentualDesconto = percentualDesconto + 0.05;
                valorBonificacao = salario * percentualDesconto;
            }
            return $"Percentual de bonificação: {Math.Round(percentualDesconto*100,0)}%\r\n" +
                   $"Valor da Bonificação: {Math.Round(valorBonificacao)}\r\n" +
                   $"Salário Final $ {salario+valorBonificacao}";
        }

    }
}
