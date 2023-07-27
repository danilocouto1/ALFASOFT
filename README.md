# ALFASOFT
# Aplica��o de Gerenciamento de Contatos

Este ReadMe descreve como usar a aplica��o ASP.NET Core para gerenciamento de contatos. Essa aplica��o permite visualizar, adicionar, editar e excluir contatos.

## Pr�-requisitos

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [MariaDB](https://mariadb.org/) (ou MySQL)

## Configura��o do Banco de Dados

1. Certifique-se de ter o MariaDB instalado em sua m�quina ou servidor.
2. Crie um banco de dados chamado "ContactsDB" no MariaDB.

## Configura��o da Conex�o com o Banco de Dados

1. No arquivo `appsettings.json`, ajuste a string de conex�o (`MariaDB`) para apontar para o banco de dados "ContactsDB" que voc� criou:

```json
"ConnectionStrings": {
  "MariaDB": "Server=localhost;Port=3306;Database=db;Uid=root;Pwd=root;"
}
Executando a Aplica��o

    Abra um terminal na pasta do projeto onde se encontra o arquivo Program.cs.
    Execute o seguinte comando para iniciar a aplica��o:
dotnet run

Acesse a aplica��o em um navegador web digitando o seguinte endere�o:
http://localhost:5000/

Rotas da Aplica��o

    Listar Contatos (Index): http://localhost:5000/
        Nesta p�gina, voc� encontrar� a lista de todos os contatos cadastrados.

    Detalhes do Contato (Details): http://localhost:5000/Details/
        Nesta p�gina, voc� encontrar� informa��es detalhadas sobre o contato selecionado.

    Adicionar Contato (Create): http://localhost:5000/Create
        Nesta p�gina, voc� poder� adicionar um novo contato preenchendo o formul�rio.

    Editar Contato (Edit): http://localhost:5000/Edit/
        Nesta p�gina, voc� poder� editar as informa��es do contato selecionado.

    Excluir Contato (Delete): http://localhost:5000/Delete/
        Nesta p�gina, voc� poder� confirmar a exclus�o do contato selecionado.