API de Contatos com CQRS e MediatR
Este projeto é uma API RESTful para gerenciamento de contatos (CRUD completo), desenvolvida com foco na separação de responsabilidades utilizando os padrões CQRS (Command Query Responsibility Segregation) e MediatR.

✨ Tecnologias Utilizadas
.NET Core (ASP.NET Core)

MediatR: Para implementação do padrão Mediator, facilitando a comunicação desacoplada entre os componentes.

CQRS: Como padrão de arquitetura para separar operações de leitura (Queries) das de escrita (Commands).

MongoDB: Como banco de dados NoSQL. O projeto utiliza o ID nativo (ObjectId) gerado pelo próprio MongoDB.

Swagger (OpenAPI): Para documentação e teste interativo da API.

📁 Estrutura do Projeto
A solução segue boas práticas de arquitetura limpa, separando as responsabilidades principais da seguinte forma:

Application/Commands: Contém todos os comandos (Create, Update, Delete) que alteram o estado do sistema.

Application/Queries: Contém todas as consultas (Read) que buscam dados do sistema.

Controllers: Camada de entrada da API, responsável por receber requisições HTTP e disparar os Comandos ou Consultas apropriados via MediatR.

⚙️ Como Configurar e Rodar
1. Pré-requisitos
.NET SDK (versão 6.0 ou superior)

Um servidor MongoDB (pode ser local ou um banco de dados em nuvem como o MongoDB Atlas)

Postman (Opcional, para testes)

2. Instalação
Clone este repositório:

Bash

git clone https://seu-repositorio-aqui.git
Configure o Banco de Dados:

Abra o arquivo appsettings.json.

Localize a seção MongoDBSettings (ou similar).

Altere a ConnectionString para apontar para o seu banco de dados MongoDB.

Execute o projeto:

Pelo Visual Studio (pressionando F5).

Ou via linha de comando:

Bash

dotnet run
⚡️ Como Usar a API
Após rodar o projeto, você pode testar os endpoints de duas maneiras:

Opção 1: Swagger (Recomendado)
Com o projeto em execução, abra seu navegador e acesse a URL principal (ex: http://localhost:5123/swagger).

O Swagger exibirá uma tela interativa com todos os endpoints disponíveis.

Você pode testar todas as operações (GET, POST, PUT, DELETE) diretamente pela interface. A API espera e retorna arquivos no formato JSON.

Opção 2: Postman (ou similar)
Você pode usar o Postman para enviar requisições para a API.

URL Base: http://localhost:[SUA_PORTA]/api/UserContact

Endpoints Principais
GET /api/UserContact

Busca todos os contatos da lista.

GET /api/UserContact/{id}

Busca um contato específico pelo seu ID.

Observação: Você deve usar o ObjectId gerado pelo MongoDB (ex: 60f1b2b3c4d5e6f7a8b9c0d1).

POST /api/UserContact

Cria um novo contato.

Envie os dados do contato no corpo (Body) da requisição em formato JSON.

PUT /api/UserContact/{id}

Atualiza um contato existente.

Envie os dados atualizados no corpo (Body) da requisição em formato JSON.

DELETE /api/UserContact/{id}

Deleta um contato pelo seu ID