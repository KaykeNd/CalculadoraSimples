// Aqui definimos que tudo que o usuário digitar vai ser uma string.
Console.WriteLine("Digite o primeiro número: ");
string número1 = Console.ReadLine();

Console.WriteLine("Digite o segundo número: ");
string número2 = Console.ReadLine();

Console.WriteLine("Digite o operador (+, -, *, /): ");
string operador = Console.ReadLine();

// Para fazermos as operações, vamos transformar strings em números.
double num1 = double.Parse(número1);
double num2 = double.Parse(número2);

double resultado = 0;// Variável que vai mostrar o resultado.
bool operacaovalida = true;// informa se está correta a operação.

// Aqui, o que o usuário escolher vai ser usado para a operação.
  if (operador == "+")
    resultado = num1 + num2;
else if (operador == "-")
    resultado = num1 - num2;
else if (operador == "*")
    resultado = num1 * num2;
else if (operador == "/")
{
    if (num2 != 0)// Se escolher 0 na divisão, dá erro.
        resultado = num1 / num2;
    else
  {
        Console.WriteLine("Erro: Divisão por zero!");
        operacaovalida = false;
  }
}
else// Se o usuário não escolher uma operação válida
{ Console.WriteLine("Operador inválido!");
  operacaovalida = false;
}
if (operacaovalida)
    Console.WriteLine("Resultado: " + resultado);