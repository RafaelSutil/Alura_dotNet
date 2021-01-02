# C# Introdu��o � Orienta��o a Objetos

Neste cap�tulo aprendemos os conceitos b�sicos de orienta��o a objetos.

#### 01-ByteBank

Criamos nossa primeira classe ContaCorrente:

```c#
public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo;
}
```

E tamb�m instanciamos e atribu�mos valores aos campos:

```c#
ContaCorrente contaDaGabriela = new ContaCorrente();

contaDaGabriela.titular = "Gabriela";
contaDaGabriela.agencia = 863;
contaDaGabriela.numero = 863452;
contaDaGabriela.saldo = 100;
```

#### 02-ByteBank

Nesta se��o aprendemos que podemos ter valores padr�es para cada campo da classe.

```c#
public class ContaCorrente
{
	// valor padrao 100 para o saldo
    public double saldo = 100;
}
```

#### 03-ByteBank

Aqui aprendemos a diferen�a dos tipos de valores para os tipos de refer�ncia.

```c#
// instanciamos do tipo ContaCorrente a contaDaGabriela e a contaDaGabrielaCosta.
ContaCorrente contaDaGabriela = new ContaCorrente();
contaDaGabriela.titular = "Gabriela";
contaDaGabriela.agencia = 863;
contaDaGabriela.numero = 863452;

ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
contaDaGabriela.titular = "Gabriela";
contaDaGabriela.agencia = 863;
contaDaGabriela.numero = 863452;

// comparamos duas instancias com valores iguais e vemos que ser� false, pois o que � comparado � a refer�ncia.
Console.WriteLine("Igualdade de tipo de referencia:" + (contaDaGabriela == contaDaGabrielaCosta));

// agora criamos duas variaveis do tipo valor (inteiro)
int idade = 27;
int idadeMaisUmaVez = 27;

// nesta compara��o notamos que ser� true, pois o que � comparado � o valor da vari�vel
Console.WriteLine("Igualdade de tipo de valor:" + (idade == idadeMaisUmaVez));

// ent�o, aqui alteramos o referencia da contaDaGabriela para a contaDaGabrielaCosta
contaDaGabriela = contaDaGabrielaCosta;
Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

// e notamos que se alterarmos algum campo da contaDaGabriela, tamb�m ser� alterado na contaDaGabrielaCosta, pois as 2 variaveis apontam para a mesma instancia.
contaDaGabriela.saldo = 300;
//ambos serao 300 pois referenciam o mesmo objeto
Console.WriteLine(contaDaGabriela.saldo);
Console.WriteLine(contaDaGabrielaCosta.saldo);
```

#### 04-ByteBank

Nesta se��o vimos que podemos adicionar fun��es dentro de nossas classes, essas fun��es tamb�m s�o chamadas de m�todos.

Fun��o verifica se o valor a ser sacado � menor que o saldo, se sim, subtrai o valor a ser sacado do saldo e retorna true, se n�o, apenas retorna false.

```c#
public bool Sacar(double valor)
{
    if (this.saldo < valor)
    {
        return false;
    }
    this.saldo -= valor;
    return true;
}
```

Fun��o que apenas soma o valor depositado ao saldo.

```c#
public void Depositar(double valor)
{
    this.saldo += valor;
}
```

Fun��o Transferir, recebe o valor a ser transferido e a conta destino, verifica se o saldo � suficiente, caso seja, usa a fun��o Depositar, para enviar o dinheiro para a conta destino, e subtrai o valor do saldo da conta do remetente.

```c#
public bool Transferir(double valor, ContaCorrente contaDestino)
{
    if (this.saldo < valor)
    {
        return false;
    }

    this.saldo -= valor;
    contaDestino.Depositar(valor);
    return true;

}
```

#### 05-ByteBank

Nesta se��o criamos uma nova classe para instanciar os clientes.

Tamb�m fomos apresentados aos namespaces que nos ajudam a organizar as classes.

````c#
public class Cliente
{
    public string nome;
    public string cpf;
    public string profissao;
}
````

#### 06-ByteBank

Aprendemos como funcionam as propriedades get e set. Tamb�m aprendemos a usar o public e private.

```c#
private double _saldo = 100;

public double Saldo
{
    get
    {
        return _saldo;
    }
    set
    {
        if (value < 0)
        {
            return;
        }
        this._saldo = value;
    }
}

public int Numero { get; set; }
public int Agencia { get; set; }
public Cliente Titular { get; set;}
```

````c#
private string _cpf;

public string Nome { get; set; }
public string CPF 
{
    get
    {
        return _cpf;
    }
    set
    {
        //Escrevo minha propria validacao para o CPF
        _cpf = value;
    } 
}
public string Profissao { get; set; }
````

#### 07-ByteBank

Nesta �ltima se��o aprendemos sobre m�todos est�ticos e como eles se comportam. E aprendemos tamb�m que podemos usar o static apenas no set sem influenciar no get.

````c#
public static int TotalDeContasCriadas { 
	get; 
	private set;
}

public ContaCorrente (int agencia, int numero)
{
    Agencia = agencia;
    Numero = numero;

    TotalDeContasCriadas++;
}
````

