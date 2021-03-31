# DESAFIO APLICATIVO DE CONSOLE 
CARTEIRA DE INVESTIMENTO

<img src="https://www.google.com/url?sa=i&url=https%3A%2F%2Fpt.wikipedia.org%2Fwiki%2FFicheiro%3AStone_pagamentos.png&psig=AOvVaw1dICKgNSK1LBuZRn8zdUNr&ust=1617290550632000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNiK-frq2u8CFQAAAAAdAAAAABAD" alt="Desafio" width="75"/>

APP Carteira de Investimento � respons�vel pelo registro de seus ativos no mercado 

Voc� pode utilizar o app para gerenciar e controlar as suas aplica��es

## How to use

Para chamar o APP basta chamar o arquivo XXXX

### Message Broker

O APP � de uso e controle pessoal, sendo assim, n�o � necess�rio nenhum registro com informa��es pessoais
 
#### >>> Notification Add and Remove

A mensagem de notifica��o ter� o seguinte:

```json
{
   "Status": "OK",
   "StatusCode": 200,
   "Transactions":[
      {
         "TransactionRef": "123",
         "Value": 10
      }
   ]
}
```


## Technologies

- .NET Core 3.1
- Visual Studio 2019
- Programa��o C#


## Getting started

Para rodar o projeto na m�quina voc� precisa ter o [Visual Studio](https://dotnet.microsoft.com/download/dotnet/5.0) instalado na m�quina.

Clone o projeto para sua m�quina e restaure os pacotes:

```shell
git clone https://github.com/csandrade16/DESAFIO
cd git-desafio/
dotnet restore
```
A aplica��o est� pronta para ser utilizada localmente.


### Building

Ap�s alterar o c�digo garanta que a aplica��o est� "buildando":

```shell
dotnet build
```


### Testing

Ap�s alterar o c�digo garanta que os testes da aplica��o est�o passando:

```shell
dotnet test //p:CollectCoverage=true //p:CoverletOutputFormat=OpenCover (para Windows)

```

O report estar� diposnivel em tests\xxx\xxx



**Environment Variables**

- ID: Indica a ordem de registro da aplica��o
- ATIVO_NOME: Indica o nome da apica��o
- ATIVO_QTE: Indica a quantidade da aplica��o


### Deploying

O deploy ocorre de forma autom�tica para o ambiente de develop, basta fazer o merge das altera��es para a branch develop no Gitlab e o pipeline ir� fazer a integra��o e deploy do seu c�digo:

```shell
git add -A
git commit -m "sua msg aqui"
git push origin {branch_desejada}
```

Para verificar o progresso do pipeline clique [aqui](http://google.com).


## Links

- [Documenta��o](https://github.com/csandrade16)
