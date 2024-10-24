//criar um cabeçalho de boas vindas
//pedir os dados de cadastro

//nome
//data de nascimento
//email
//telefone
//cpf
//endereço
//idade-calcular baseado na data de nascimento
//estado civil

//variaveis e tipos de dados
Console.WriteLine(@"
   +--------------------------------------+
   |              Bem-Vindo(a)            |
   + -------------------------------------+
   ");


System.Console.WriteLine($"Ola, digite seu nome: ");
string nome = Console.ReadLine();
System.Console.WriteLine($"Agora digite seu sobrenome: ");
string sobrenome = Console.ReadLine();

// System.Console.WriteLine($"Agora digite seu ano de nascimento: ");
// string DtNascimento = Console.ReadLine();

System.Console.WriteLine($"Agora digite seu email: ");
string email = Console.ReadLine();

System.Console.WriteLine($"Agora digite seu telefone: ");
UInt128 telefone = UInt128.Parse(Console.ReadLine()!);

System.Console.WriteLine($"Agora digite seu cpf: ");
UInt128 cpf = UInt128.Parse(Console.ReadLine()!);

System.Console.WriteLine($"Agora digite seu enderço: ");
string endereço = Console.ReadLine();

System.Console.WriteLine($"Agora digite seu Estado Civil: ");
string EstadoCivil = Console.ReadLine();


System.Console.WriteLine($"em que ano voce nasceu ");
int AnoNascimento = int.Parse(Console.ReadLine()!);
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - AnoNascimento;

//mostrar esse dados cadastrado

Console.WriteLine("Cadastro concluido \n\n");
//Clw
Console.WriteLine(@$"Obrigado, {nome} {sobrenome}
nasceu em: {AnoNascimento}
email: {email}
telefone: {telefone}
cpf:{cpf}
mora em: {endereço}
ano atual : {anoAtual}
idade: {idade}
Estado Civil: {EstadoCivil}

");

//estrutura   consicionais
//laços de repetição
//arrays

