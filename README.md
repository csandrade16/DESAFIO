# DESAFIO APLICATIVO DE CONSOLE 
CARTEIRA DE INVESTIMENTO

<img src="https://www.google.com/url?sa=i&url=https%3A%2F%2Fpt.wikipedia.org%2Fwiki%2FFicheiro%3AStone_pagamentos.png&psig=AOvVaw1dICKgNSK1LBuZRn8zdUNr&ust=1617290550632000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNiK-frq2u8CFQAAAAAdAAAAABAD" alt="Desafio" width="75"/>

APP Carteira de Investimento é responsável pelo registro de seus ativos no mercado 

Você pode utilizar o app para gerenciar e controlar as suas aplicações

## How to use

Para chamar o APP basta chamar o arquivo XXXX

### Message Broker

O APP é de uso e controle pessoal, sendo assim, não é necessário nenhum registro com informações pessoais
 
#### >>> Notification Add and Remove

A mensagem de notificação terá o seguinte:

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
- Programação C#


## Getting started

Para rodar o projeto na máquina você precisa ter o [Visual Studio](https://dotnet.microsoft.com/download/dotnet/5.0) instalado na máquina.

Clone o projeto para sua máquina e restaure os pacotes:

```shell
git clone https://github.com/csandrade16/DESAFIO
cd git-desafio/
dotnet restore
```
A aplicação está pronta para ser utilizada localmente.


### Building

Após alterar o código garanta que a aplicação está "buildando":

```shell
dotnet build
```


### Testing

Após alterar o código garanta que os testes da aplicação estão passando:

```shell
dotnet test //p:CollectCoverage=true //p:CoverletOutputFormat=OpenCover (para Windows)

```

O report estará diposnivel em tests\xxx\xxx



**Environment Variables**

- ID: Indica a ordem de registro da aplicação
- ATIVO_NOME: Indica o nome da apicação
- ATIVO_QTE: Indica a quantidade da aplicação


### Deploying

O deploy ocorre de forma automática para o ambiente de develop, basta fazer o merge das alterações para a branch develop no Gitlab e o pipeline irá fazer a integração e deploy do seu código:

```shell
git add -A
git commit -m "sua msg aqui"
git push origin {branch_desejada}
```

Para verificar o progresso do pipeline clique [aqui](http://google.com).


## Links

- [Documentação](https://github.com/csandrade16)
