// See https://aka.ms/new-console-template for more information

//Limpa o console pra maior organização.
Console.Clear();

//Mensagens de boas vindas e instruções iniciais.
Console.WriteLine("--Calculadora simples em C#--");
Console.WriteLine("Digite o primeiro número e pressione Enter. Obs: Apenas algarismos e \",\" são aceitos ");

//Lê o que foi digitado pelo usuário
string inputNumero1 = Console.ReadLine() ?? "";

//Converte o que foi digitado para um número para que seja interpretado.
double numero1 = double.Parse(inputNumero1);

//Mostra o número já convertido, para a confirmação
Console.WriteLine($"Primeiro número é {numero1}");

//Pede o operador matemático.
Console.WriteLine("Insira o operador (+,-,/,*) e pressione Enter.");

//Lê o operador.
string operador = Console.ReadLine() ?? "";

//Pede o segundo número.
Console.WriteLine("Digite o segundo número e pressione Enter. Obs: Apenas algarismos e \",\" são aceitos ");

//Lê o segundo número.
string inputNumero2 = Console.ReadLine() ?? "";

//Converte o segundo número.
double numero2 = double.Parse(inputNumero2);

//Confirma a operação.
Console.WriteLine($"Sua operação é: {numero1}{operador}{numero2}");

//Lógica do cálculo
double resultado = 0;

switch (operador)
{
    case "+":
        resultado = numero1 + numero2; 
        break;
    case "-":
        resultado = numero1 - numero2;
       break;
    case "*":
        resultado = numero1 * numero2;
        break;
    case "/":
        //Tratamento de divisão por zero
        if (numero2 != 0)
        {
            resultado = numero1 / numero2;
        }
        else
        {
            Console.WriteLine("Erro: Não é possível dividir por 0");
            return; //Encerra o programa para evitar erro de divisão por 0.
        }
            
        break;

    default://Encerra o programa por operador inválido.
        Console.WriteLine("Erro: Operador inválido.");
        return;
}

//Mostra o resultado.
Console.WriteLine("__________________________________________");
Console.WriteLine($"O resultado da operação é {resultado}");









