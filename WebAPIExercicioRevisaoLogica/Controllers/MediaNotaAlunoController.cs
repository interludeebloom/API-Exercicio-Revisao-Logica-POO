using Microsoft.AspNetCore.Mvc;

namespace WebAPIExercicioRevisaoLogica.Controllers
{
    public class MediaNotaAlunoController : Controller
    {
        [HttpPost("MediaNotaAluno")]
        public string MediaNotaAluno(double nota1Aluno,
                                     double nota2Aluno,
                                     int faltaAluno)
        {
            double nota1, nota2, mediaNota;
            int falta;
            string situacaoAluno = "";

            nota1 = nota1Aluno;
            nota2 = nota2Aluno;
            falta = faltaAluno;

            //Processamento
            mediaNota = (nota1 + nota2) / 2;

            if ((mediaNota >= 7) && (falta <= 10))
            {
                situacaoAluno = "Aluno Aprovado";
            }
            else if ((mediaNota < 7) && (falta <= 10))
            {
                situacaoAluno = "Aluno Reprovado";
            }
            else if (falta > 10)
            {
                situacaoAluno = "Aluno Reprovado por faltas";
            }
            //saida

            return $"Média Nota Aluno: {mediaNota}\r\nSituação:{situacaoAluno}";
        }
    }
}
