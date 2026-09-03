//declaração das variáveis
int idade;
string senha, resultadoPermissao = "", acessoPermitido;
//ENTRADA
Console.WriteLine("Informe a idade do usuário");
idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a senha do usuário");
senha = Console.ReadLine();

Console.WriteLine("Informe SIM OU NÃO se usuário possui acesso ao sistema");
acessoPermitido = Console.ReadLine();

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
Console.WriteLine(resultadoPermissao);