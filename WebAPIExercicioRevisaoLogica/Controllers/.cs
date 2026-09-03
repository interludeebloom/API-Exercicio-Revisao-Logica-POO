using Microsoft.AspNetCore.Mvc;

namespace WebAPIExercicioRevisaoLogica.Controllers
{
    public class ValidacaoContaUsuarioController : Controller
    {
        [HttpPost("ValidacaoContaUsuario")]
        public string ValidacaoContaUsuario(int idadeUsuario,
                                            string senhaUsuario,
                                            string acessoPermitidoUsuario)
        {
            //declaração das variáveis
            int idade;
            string senha, resultadoPermissao = "", acessoPermitido;

            idade = idadeUsuario;
            senha = senhaUsuario;
            acessoPermitido = acessoPermitidoUsuario;


            //PROCESSAMENTO
            if ((idade >= 18) && (senha == "Senh@10082026") && (acessoPermitido == "SIM"))
            {
                resultadoPermissao = "ACESSO PERMITIDO";
            }
            else
            {
                resultadoPermissao = "ACESSO NEGADO";
            }

            //SAIDA
            //Console.WriteLine(resultadoPermissao);

            return resultadoPermissao;
        }
    }
}
