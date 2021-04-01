# DESAFIO APLICATIVO DE CONSOLE 
CARTEIRA DE INVESTIMENTO

APP Carteira de Investimento � respons�vel pelo registro de seus ativos no mercado 

Voc� pode utilizar o app para gerenciar e controlar as suas aplica��es

## How to use

Basta seguir as orienta��es do Menu da aplica��o para fazer o manuseio de seus ativos, podendo assim adicionar, remover e visualizar seus investimentos.

### Additional Message 

O APP � de uso e controle pessoal, sendo assim, n�o � necess�rio nenhum registro com informa��es pessoais
 

## Technologies

- .NET Core 3.1
- Visual Studio 2019
- Programa��o C#


## Getting started

Para rodar o projeto na m�quina voc� precisa ter o [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/) instalado na m�quina.

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
https://github.com/csandrade16/DESAFIO/tree/main/AppConsole/Desafio.Testes

```

**Environment Variables**

- ATIVO_ID: Indica a ordem de registro da aplica��o
- ATIVO_NOME: Indica o nome da apica��o
- ATIVO_QTE: Indica a quantidade da aplica��o
- ATIVO_VUNIT: Registra o valor unit�rio da aplica��o
- ATIVO_VTOTAL: Indica o valor total da aplica��o
- ATIVO_DTHR: Indica a hora do registro da aplica��o


### Update Version

O update de forma autom�tica para o ambiente, basta fazer o merge das altera��es para a branch develop no Gitlab do seu c�digo:

```shell
git add -A
git commit -m "sua msg aqui"
git push origin {branch_desejada}
```


## Links

- [Documenta��o](https://github.com/csandrade16)
