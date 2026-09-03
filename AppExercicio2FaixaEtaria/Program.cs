int idade;
string classificacaoFaixaEtaria = "", situacaoVoto = "";
Console.WriteLine("Informe sua Idade");
idade = Convert.ToInt32(Console.ReadLine());

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
Console.WriteLine($"A idade da pessoa é:{idade}");
Console.WriteLine(classificacaoFaixaEtaria);
Console.WriteLine($"Situacao do Voto: {situacaoVoto}");
