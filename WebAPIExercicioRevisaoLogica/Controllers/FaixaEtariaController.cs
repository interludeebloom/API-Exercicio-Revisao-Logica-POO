using Microsoft.AspNetCore.Mvc;

namespace WebAPIExercicioRevisaoLogica.Controllers
{
    public class FaixaEtariaController : Controller
    {
        [HttpGet("ClassificacaoFaixaEtaria")]
        public string ClassificacaoFaixaEtaria(int idadePessoa)
        {
            //Declaração Variaveis
            int idade;
            string classificacaoFaixaEtaria = "", situacaoVoto = "";

            idade = idadePessoa;

            //PROCESSAMENTO
            if ((idade > 0) && (idade < 13))
            {
                classificacaoFaixaEtaria = "Classificação:CRIANÇA";
                situacaoVoto = "VOTO PROIBIDO";

            }
            else if ((idade >= 13) && (idade <= 17))
            {
                classificacaoFaixaEtaria = "Classificação:ADOLESCENTE";
                if ((idade >= 16) && (idade <= 17))
                {
                    situacaoVoto = "VOTO FACULTATIVO";
                }
                else
                {
                    situacaoVoto = "VOTO PROIBIDO";
                }
            }
            else if ((idade > 17) && (idade <= 59))
            {
                classificacaoFaixaEtaria = "Classificação:ADULTO";
                situacaoVoto = "VOTO OBRIGATÓRIO";
            }
            else
            {
                classificacaoFaixaEtaria = "Classificação:IDOSO";
                situacaoVoto = "VOTO FACULTATIVO";
            }
            // saida
            //Console.WriteLine($"A idade da pessoa é:{idade} anos");
            //Console.WriteLine(classificacaoFaixaEtaria);
            //Console.WriteLine($"Situação do Voto:{situacaoVoto}");

            return $"A idade da pessoa é: {idade} anos\r\n"+
                   $"Classificação da Faixa Etária {classificacaoFaixaEtaria}\r\n"+
                   $"Situação do Voto:{situacaoVoto}";
        }
    }
}
