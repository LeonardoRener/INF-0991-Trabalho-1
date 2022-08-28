
Console.WriteLine("{0}", new String('=', 50)); 
Console.WriteLine("Aula 01");
// Outra alteração realizada por Leonardo
//Outra alteração realizada por Patrick.

// Exercícios
//Alteração realizada por Patrick.
/* 1) Faça um programa que imprima o primeiro número, entre 1 e 1000, que seja divisível 
por 7, 13, 17. Implemente sua solução com o comando break.*/
for(int i = 1; i <= 1000; i++)
{
    if((i % 7) == 0 && (i % 13) == 0 && (i % 17) == 0)
    {
        Console.WriteLine("O numero encontrado foi {0}.", i);
        break;
    }
}

/* 2) Faça um programa que some todos os números de 1 até 1000, exceto os múltiplo de 5. 
Implemente duas versões: com e sem o comando continue.*/
int result = 0;
for(int i = 1; i <= 1000; i++)
{
    if((i % 5) != 0)
    {
        result += i;
    }
}

Console.WriteLine("Total da soma = {0} - versao versões sem o comando continue.", result);

result = 0;
for(int i = 1; i <= 1000; i++)
{
    if((i % 5) == 0)
    {
        continue;
    }
    result += i;
}

Console.WriteLine("Total da soma = {0} - versao versões com o comando continue.", result);
// Alteração realizada por Leonardo
Console.WriteLine("{0}", new String('=', 50));R