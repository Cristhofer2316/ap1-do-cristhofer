using System.Reflection;
using System.Xml.Serialization;

double altura;
float peso;
int idade;
string nome;
double imc;
double imc2;
int programa;
while (true)
{
    Console.WriteLine("digite seu nome:");
    nome = Console.ReadLine();

    Console.WriteLine("digite sua idade:");
    idade = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("digite sua altura:");
    altura = Convert.ToDouble(Console.ReadLine());

    System.Console.WriteLine("digite seu peso:");
    peso = Convert.ToInt32(Console.ReadLine());

    imc = altura * altura;
    
    imc2 = peso / imc;
   
    if (idade >0 & idade <12)
    {
        System.Console.WriteLine($"Seu nome é {nome}, sua idade é {idade}, seu IMC é de {imc2} e sua faixa etária é de criaça:");
    }
    if (idade >=12 & idade <18)
    {
        System.Console.WriteLine($"Seu nome é {nome}, sua idade é {idade}, seu IMC é de {imc2} e sua faixa etária é de adoleçente:");
    }
    if (idade >=18 & idade <60)
    {
        System.Console.WriteLine($"Seu nome é {nome}, sua idade é {idade}, seu IMC é de {imc2} e sua faixa etária é de adulto:");
    }
    else if(idade >=60)
    {
        System.Console.WriteLine($"Seu nome é {nome}, sua idade é {idade}, seu IMC é de {imc2} e sua faixa etária é de idoso:");
    }

    System.Console.WriteLine("quer refazer o teste? 1 para (sim), 2 para (não)");
    programa = Convert.ToInt32(Console.ReadLine());

    

    if (programa == 2)
        System.Console.WriteLine("programa encerrado!!");
        break;
}


