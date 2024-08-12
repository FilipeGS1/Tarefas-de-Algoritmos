/*Console.WriteLine("Digite seu nome:");
var nome = Console.ReadLine();

Console.WriteLine("Olá, " + nome + ", digite o valor de a");

var a =   int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de b");

int b =   int.Parse(Console.ReadLine());

Console.WriteLine("A soma de a e b é: " + (a+b)); 

Console.WriteLine("Digite um número");

int numero = int.Parse(Console.ReadLine());

bool par = numero % 2 == 0 ;

if(par){
    Console.WriteLine("Número par");
}
else{
    Console.WriteLine("Número ímpar");
}

string senha = "1234";

Console.WriteLine("Digite a senha");

string senhaDigitada = Console.ReadLine();

if(senha == senhaDigitada){
    Console.WriteLine("Entrou");
}
else{
    Console.WriteLine("Senha incorreta");
}*/

Console.WriteLine("Digite uma nota");
int nota = int.Parse(Console.ReadLine());

if(nota >= 60){
    Console.WriteLine("Aprovado");
}
else if (nota >= 20){
    Console.WriteLine("Recuperação");
}
else{
    Console.WriteLine("Reprovado");
}