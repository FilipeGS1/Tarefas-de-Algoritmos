Console.WriteLine ("Digite o valor da nota1:");
int nota1 = int.Parse(Console.ReadLine());

if(nota1 > 100 || nota1 < 0)
{
    Console.WriteLine("Valor inválido");
    return;
}

Console.WriteLine ("Digite o valor da nota1:");
int nota2 = int.Parse(Console.ReadLine());

if(nota2 > 100 || nota2 < 0)
{
    Console.WriteLine("Valor inválido");
    return;
}

Console.WriteLine ("Digite o valor da nota1:");
int nota3 = int.Parse(Console.ReadLine());

if(nota3 > 100 || nota3 < 0)
{
    Console.WriteLine("Valor inválido");
    return;
}

Console.WriteLine ("Digite o valor da nota1:");
int nota4 = int.Parse(Console.ReadLine());

if(nota4 > 100 || nota4 < 0)
{
    Console.WriteLine("Valor inválido");
    return;
}

float media = (2*nota1 + 2*nota2 + 3*nota3 + 3*nota4) / 10f;
media = (float)Math.Round(media);
Console.WriteLine("Média da disciplina: " + media);

if(media >= 60){
    Console.WriteLine("Aprovado");
    return;
}
if(media < 20){
    Console.WriteLine("Reprovado");
    return;
}
else{
    Console.WriteLine("Recuperação");
    float previsao = 120 - media;
    Console.WriteLine($"Precisa tirar {previsao} para passar");
}

Console.WriteLine("Digite o valor da provaFinal:");
int provaFinal = int.Parse(Console.ReadLine());

if(provaFinal > 100 || provaFinal < 0)
{
    Console.WriteLine("Valor inválido");
    return;
}
float mediaFinal = (media + provaFinal) / 2f;
mediaFinal = (float)Math.Round(mediaFinal);
Console.WriteLine("Média final: " + mediaFinal);

if(mediaFinal >= 60){
    Console.WriteLine("Aprovado");
}
else{
    Console.WriteLine("Reprovado");
}