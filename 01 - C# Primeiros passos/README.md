# C# Primeiros passos

Neste cap�tulo tivemos uma introdu��o ao C#, conhecendo a estrutura de um programa como tamb�m alguns comandos b�sicos.

#### 1. Primeiro Projeto

Aprendemos um pouco sobre a hist�ria e ecossistema .NET.

Fizemos o download e instala��o do Visual Studio.

Criamos nosso primeiro programa "Ol�, mundo", onde aprendemos os comandos b�sicos de leitura e escrita como:

```c#
Console.WriteLine("Escreve e pula linha");

Console.Write("Escreve sem pular a linha no final");

// L� o pr�ximo caractere do fluxo de entrada padr�o.
Console.Read();

// L� a pr�xima linha de caracteres do fluxo de entrada padr�o.
Console.ReadLine();

// Obt�m o pr�ximo caractere ou tecla de fun��o pressionada pelo usu�rio.
Console.ReadKey();
```

#### 2. Criando Vari�veis

Aprendemos como as vari�veis s�o criadas, como opera��es aritm�ticas s�o feitas, e como podemos concatenar valores dentro do comando de escrever na tela.

```c#
// declara��o da vari�vel inteira
int idade = 10;
// express�o aritm�tica onde ser� priorizado a multiplica��o
idade = 10 + 5 * 2;
// concatenamos o inteiro com as strings para ser escrito na tela
Console.WriteLine("Sua idade � " + idade + "anos.");
```

#### 3. Criando vari�veis ponto flutuante

Aprendemos o que � uma vari�vel ponto flutuante, e como podemos us�-la.

```c#
// declara��o de uma vari�vel double
double salario = 1200.70;

double idade;
idade = 15 / 2;
// mesmo a vari�vel sendo um double, o resultado ser� 7 pois ser� considerado a divis�o de 2 inteiros
Console.WriteLine("15 / 2 = " + idade);

// aqui sim o resultado ser� 7.5, pois o C# entende que � a divis�o de um decimal
idade = 15.0 / 2;
Console.WriteLine("15.0 / 2 = "+ idade);
```

#### 4. Convers�o e outros tipos de dados

Aprendemos a atribuir o valor da vari�vel double em uma vari�vel inteira.

```c#
double salario = 1200.5;
int salarioEmInteiro;

sal�rioEmInteiro = (int)salario;
```

Aprendemos tamb�m mais alguns tipos de dados.

```c#
// tamb�m � do tipo inteiro por�m � maior 2^64, lembrando que o int tem 2^32
long idade;
// outro inteiro, por�m menor que o int, tendo apenas 2^16 bits
short qtdProdutos;
// decimal como o double, por�m com menos casas decimais, na atribui��o devemos especificar um f ap�s o n�mero.
float altura = 1.80f;
```

#### 5. Caracteres e textos

Aprendemos como utilizar uma vari�vel do tipo char e do tipo string, como tamb�m aprendemos a utilizar a tabela ascii.

```c#
// atribuicao do caractere 'a'
char primeiraLetra = 'a';
// atribui��o do caractere 'A', pela tabela ascii
primeiraLetra = (char)65;
// atribui��o de uma string "Isso � uma string 123"
string titulo = "Isso � uma string " + 123;
    
```

#### 6. Atribui��o de vari�veis

Pequena se��o onde vimos como vari�veis s�o atribu�das.

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

Conhecemos o tipo booleano e express�es l�gicas que podemos fazer dentro da instru��o if

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

Mais um se��o simples, onde aprendemos que vari�veis criadas dentro de um escopo, n�o existe fora dele, por exemplo, se criarmos uma vari�vel dentro de um if, ou um for, n�o existira fora.

#### 10. Calcula Poupan�a I

Nesta se��o fizemos uso de mais uma instru��o nova, aprendemos como utilizar o while.

```c#
// a instru��es dentro do while ficar�o sendo executadas at� que a condi��o n�o seja mais satisfeita
while (contadorMes <= 12)
{
    valorInvestido = valorInvestido + valorInvestido * 0.0036;
    Console.WriteLine("Apos " + contadorMes + " mes, voce tera R$" + valorInvestido);
    contadorMes++;
}
```

#### 11. Calcula Poupan�a II

Aqui j� fizemos uso da instru��o for, que tem a mesma funcionalidade que o while, por�m temos uma facilidade maior com a vari�vel contador.

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
        Console.WriteLine("Ap�s " + contadorMes + " meses, voce ter� R$" + valorInvestido);
    }
    fatorRendimento += 0.001;
}
```

#### 13. for Encadeado

Aqui temos mais um exemplo de como encadear a instru��o for, mas aqui fizemos de duas maneiras, usando o comando break, e apenas usando a condi��o do for interno.

O objetivo � que a sa�da seja:

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
// neste for usamos a instru��o break para pular as linhas
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

