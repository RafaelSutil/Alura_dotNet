# C# Primeiros passos

Neste capítulo tivemos uma introdução ao C#, conhecendo a estrutura de um programa como também alguns comandos básicos.

#### 1. Primeiro Projeto

Aprendemos um pouco sobre a história e ecossistema .NET.

Fizemos o download e instalação do Visual Studio.

Criamos nosso primeiro programa "Olá, mundo", onde aprendemos os comandos básicos de leitura e escrita como:

```c#
Console.WriteLine("Escreve e pula linha");

Console.Write("Escreve sem pular a linha no final");

// Lê o próximo caractere do fluxo de entrada padrão.
Console.Read();

// Lê a próxima linha de caracteres do fluxo de entrada padrão.
Console.ReadLine();

// Obtém o próximo caractere ou tecla de função pressionada pelo usuário.
Console.ReadKey();
```

#### 2. Criando Variáveis

Aprendemos como as variáveis são criadas, como operações aritméticas são feitas, e como podemos concatenar valores dentro do comando de escrever na tela.

```c#
// declaração da variável inteira
int idade = 10;
// expressão aritmética onde será priorizado a multiplicação
idade = 10 + 5 * 2;
// concatenamos o inteiro com as strings para ser escrito na tela
Console.WriteLine("Sua idade é " + idade + "anos.");
```

#### 3. Criando variáveis ponto flutuante

Aprendemos o que é uma variável ponto flutuante, e como podemos usá-la.

```c#
// declaração de uma variável double
double salario = 1200.70;

double idade;
idade = 15 / 2;
// mesmo a variável sendo um double, o resultado será 7 pois será considerado a divisão de 2 inteiros
Console.WriteLine("15 / 2 = " + idade);

// aqui sim o resultado será 7.5, pois o C# entende que é a divisão de um decimal
idade = 15.0 / 2;
Console.WriteLine("15.0 / 2 = "+ idade);
```

#### 4. Conversão e outros tipos de dados

Aprendemos a atribuir o valor da variável double em uma variável inteira.

```c#
double salario = 1200.5;
int salarioEmInteiro;

salárioEmInteiro = (int)salario;
```

Aprendemos também mais alguns tipos de dados.

```c#
// também é do tipo inteiro porém é maior 2^64, lembrando que o int tem 2^32
long idade;
// outro inteiro, porém menor que o int, tendo apenas 2^16 bits
short qtdProdutos;
// decimal como o double, porém com menos casas decimais, na atribuição devemos especificar um f após o número.
float altura = 1.80f;
```

#### 5. Caracteres e textos

Aprendemos como utilizar uma variável do tipo char e do tipo string, como também aprendemos a utilizar a tabela ascii.

```c#
// atribuicao do caractere 'a'
char primeiraLetra = 'a';
// atribuição do caractere 'A', pela tabela ascii
primeiraLetra = (char)65;
// atribuição de uma string "Isso é uma string 123"
string titulo = "Isso é uma string " + 123;
    
```

#### 6. Atribuição de variáveis

Pequena seção onde vimos como variáveis são atribuídas.

```c#
int idade = 32;
// idadeGustavo = 32
int idadeGustavo = idade;

idade = 20;

Console.WriteLine(idade); // idade = 20
Console.WriteLine(idadeGustavo); // idadeGustavo = 32
```

#### 7. Condicionais I

Aprendemos o funcionamento do if else.

```c#
int idadeJoao = 16, quantidadePessoas = 2;

if (idadeJoao >= 18)
{
	Console.WriteLine("Joao possui mais de 18 anos de idade.");
}
else
{
	if (quantidadePessoas >= 2)
	{
		Console.WriteLine("Joao nao possui mais de 18 anos mas esta acompanhado.");
	}
	else
	{
		Console.WriteLine("Joao nao possui mais de 18 anos.");
	}
}
```

#### 8. Condicionais II

Conhecemos o tipo booleano e expressões lógicas que podemos fazer dentro da instrução if

```c#
int idadeJoao = 16, quantidadePessoas = 2;

bool acompanhado = quantidadePessoas >= 2;

if (idadeJoao >= 18 || acompanhado == true)
{
    Console.WriteLine("Joao pode entrar.");
}
else
{
    Console.WriteLine("Joao nao pode entrar");
}

if (idadeJoao >= 18 && acompanhado)
{
    Console.WriteLine("Joao pode entrar.");
}
else
{
    Console.WriteLine("Joao nao pode entrar");
}
```

#### 9. Escopo

Mais um seção simples, onde aprendemos que variáveis criadas dentro de um escopo, não existe fora dele, por exemplo, se criarmos uma variável dentro de um if, ou um for, não existira fora.

#### 10. Calcula Poupança I

Nesta seção fizemos uso de mais uma instrução nova, aprendemos como utilizar o while.

```c#
// a instruções dentro do while ficarão sendo executadas até que a condição não seja mais satisfeita
while (contadorMes <= 12)
{
    valorInvestido = valorInvestido + valorInvestido * 0.0036;
    Console.WriteLine("Apos " + contadorMes + " mes, voce tera R$" + valorInvestido);
    contadorMes++;
}
```

#### 11. Calcula Poupança II

Aqui já fizemos uso da instrução for, que tem a mesma funcionalidade que o while, porém temos uma facilidade maior com a variável contador.

```c#
for(int contadorMes = 1; contadorMes <=12; contadorMes++)
{
    valorInvestido *= 1.0036;
    Console.WriteLine("Apos " + contadorMes + " meses, voce tera R$" + valorInvestido);
}
```

#### 12. Calcula Investimento Longo Prazo

Aqui aprendemos como funciona um for dentro de um for, para isso resolvemos o problema de que a cada ano o fator de rendimento aumentava 0.001.

```c#
for (int contadorAno = 1; contadorAno <=5; contadorAno++)
{
    for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
    {
        valorInvestido *= fatorRendimento;
        Console.WriteLine("Após " + contadorMes + " meses, voce terá R$" + valorInvestido);
    }
    fatorRendimento += 0.001;
}
```

#### 13. for Encadeado

Aqui temos mais um exemplo de como encadear a instrução for, mas aqui fizemos de duas maneiras, usando o comando break, e apenas usando a condição do for interno.

O objetivo é que a saída seja:

```
*
**
***
****
*****
******
*******
********
*********
```

```c#
// neste for usamos a instrução break para pular as linhas
for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
	for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
	{
		Console.Write("*");
		if (contadorColuna >= contadorLinha)
			break;
		}
		Console.WriteLine();
	}


for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
    for(int contadorColuna = 0; contadorColuna < contadorLinha; contadorColuna++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
```

