# DESAFIO APLICATIVO DE CONSOLE 
CARTEIRA DE INVESTIMENTO

APP Carteira de Investimento é responsável pelo registro de seus ativos no mercado 

Você pode utilizar o app para gerenciar e controlar as suas aplicações

## How to use

Basta seguir as orientações do Menu da aplicação para fazer o manuseio de seus ativos, podendo assim adicionar, remover e visualizar seus investimentos.

### Additional Message 

O APP é de uso e controle pessoal, sendo assim, não é necessário nenhum registro com informações pessoais
 

## Technologies

- .NET Core 3.1
- Visual Studio 2019
- Programação C#


## Getting started

Para rodar o projeto na máquina você precisa ter o [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/) instalado na máquina.

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
https://github.com/csandrade16/DESAFIO/tree/main/AppConsole/Desafio.Testes

```

**Environment Variables**

- ATIVO_ID: Indica a ordem de registro da aplicação
- ATIVO_NOME: Indica o nome da apicação
- ATIVO_QTE: Indica a quantidade da aplicação
- ATIVO_VUNIT: Registra o valor unitário da aplicação
- ATIVO_VTOTAL: Indica o valor total da aplicação
- ATIVO_DTHR: Indica a hora do registro da aplicação


### Update Version

O update de forma automática para o ambiente, basta fazer o merge das alterações para a branch develop no Gitlab do seu código:

```shell
git add -A
git commit -m "sua msg aqui"
git push origin {branch_desejada}
```


## Links

- [Documentação](https://github.com/csandrade16)
