# ALFASOFT
# Aplicação de Gerenciamento de Contatos

Este ReadMe descreve como usar a aplicação ASP.NET Core para gerenciamento de contatos. Essa aplicação permite visualizar, adicionar, editar e excluir contatos.

## Pré-requisitos

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [MariaDB](https://mariadb.org/) (ou MySQL)

## Configuração do Banco de Dados

1. Certifique-se de ter o MariaDB instalado em sua máquina ou servidor.
2. Crie um banco de dados chamado "ContactsDB" no MariaDB.

## Configuração da Conexão com o Banco de Dados

1. No arquivo `appsettings.json`, ajuste a string de conexão (`MariaDB`) para apontar para o banco de dados "ContactsDB" que você criou:

```json
"ConnectionStrings": {
  "MariaDB": "Server=localhost;Port=3306;Database=db;Uid=root;Pwd=root;"
}
Executando a Aplicação

    Abra um terminal na pasta do projeto onde se encontra o arquivo Program.cs.
    Execute o seguinte comando para iniciar a aplicação:
dotnet run

Acesse a aplicação em um navegador web digitando o seguinte endereço:
http://localhost:5000/

Rotas da Aplicação

    Listar Contatos (Index): http://localhost:5000/
        Nesta página, você encontrará a lista de todos os contatos cadastrados.

    Detalhes do Contato (Details): http://localhost:5000/Details/
        Nesta página, você encontrará informações detalhadas sobre o contato selecionado.

    Adicionar Contato (Create): http://localhost:5000/Create
        Nesta página, você poderá adicionar um novo contato preenchendo o formulário.

    Editar Contato (Edit): http://localhost:5000/Edit/
        Nesta página, você poderá editar as informações do contato selecionado.

    Excluir Contato (Delete): http://localhost:5000/Delete/
        Nesta página, você poderá confirmar a exclusão do contato selecionado.
