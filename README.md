<img src="https://github.com/loppnowcd/loppnowcd/blob/main/readmeheaderimage.png" alt="Cabeçalho do Readme / Readme header.">

# Movie API - Junior Backend Developer Challenge

### Project Overview

This is a .NET 8 Web API developed as part of a coding assessment for a Junior Backend Developer position. The API fetches popular movie data from a third-party API, processes it, and persists the relevant information to a SQL Server database.

### Technical Stack

- **.NET 8 Web API:** The core framework for the application.
- **Entity Framework Core:** Used for Object-Relational Mapping (ORM) and database management (Migrations).
- **SQL Server:** The relational database used for data persistence.
- **The Movie Database (TMDb):** The third-party API used to fetch movie data.

### Getting Started: A Step-by-Step Guide

Follow these instructions to get the project up and running on your local machine. Don't worry, I've made it as simple as possible for you.

#### Prerequisites

- **.NET 8 SDK:** Download and install the latest SDK from the official Microsoft website.
- **SQL Server LocalDB:** This is usually installed automatically with Visual Studio.

#### Setup Instructions

1.  **Clone the repository:**
    Start by opening your terminal or Git Bash.
    ```bash
    git clone https://github.com/loppnowcd/movie-api-dotnet-challange.git
    cd movie-api-dotnet-challange
    ```
2.  **Restore dependencies:**
    Inside the project folder, run the command to restore all required NuGet packages.
    ```bash
    dotnet restore
    ```
3.  **Configure API Key:**
    - The API uses The Movie Database (TMDb) for data. You will need a personal API key from their developer portal.
    - To keep your key safe, we use a separate file for local development. Inside the `MovieApi` folder, create a new file named `appsettings.Development.json`.
    - Now, just paste your API key into this file. It should look like this:
    ```json
    {
      "ApiSettings": {
        "MovieDbApiKey": "INSERIR_A_CHAVE_AQUI"
      }
    }
    ```
    *(Tip: Remember to replace "INSERIR_A_CHAVE_AQUIE" with the actual key!)*
4.  **Run Migrations:**
    - This is a crucial step! It will create the database and the `Movies` table for you. No need to worry about writing SQL queries.
    - In your terminal, make sure you are in the project folder (`MovieApi/MovieApi`) and run the command below.
    ```bash
    dotnet ef database update
    ```
  
5.  **Run the application:**
    - We're almost there! Run the command below to start the API.
    ```bash
    dotnet run --project MovieApi/Api/MovieApi.Api.csproj
    ```
    - The API will be available at `https://localhost:7000`. You'll see a confirmation message in the terminal.
  

## API Endpoints: A Quick Test Drive

Now that the API is running, let's test it using Swagger. You'll love this!

1.  **Open Swagger:**
    - Open your browser and navigate to `https://localhost:7000/swagger`.
    - You will see the documentation for our API.

2.  **Fetch and Save Movies:**
    - Look for the `GET /api/Movie/fetch-and-save-popular-movies` endpoint.
    - Click on it, then click the "Try it out" button.
    - Finally, hit "Execute." You will see the magic happen! Your API will call TMDb, get the movies, and save them directly to your database.

## Third-Party API Documentation

- [The Movie Database (TMDb) API Documentation](https://developers.themoviedb.org/3)

---

## Português

### Visão Geral do Projeto

Esta é uma API Web em .NET 8 desenvolvida como parte de um processo de avaliação para a vaga de Desenvolvedor Backend Júnior. A API busca dados de filmes populares de uma API de terceiros, processa-os e persiste as informações relevantes em um banco de dados SQL Server.

### Tecnologias Utilizadas

- **.NET 8 Web API:** O framework principal da aplicação.
- **Entity Framework Core:** Utilizado para Mapeamento Objeto-Relacional (ORM) e gerenciamento de banco de dados (Migrations).
- **SQL Server:** O banco de dados relacional utilizado para persistência de dados.
- **The Movie Database (TMDb):** A API de terceiros utilizada para buscar dados de filmes.

### Como Começar: Um Guia Passo a Passo

Siga estas instruções para colocar o projeto em funcionamento na sua máquina local. Não se preocupe, eu facilitei o máximo possível para você.

#### Pré-requisitos

- **.NET 8 SDK:** Baixe e instale o SDK mais recente no site oficial da Microsoft.
- **SQL Server LocalDB:** Geralmente é instalado automaticamente com o Visual Studio.

#### Instruções de Configuração

1.  **Clone o repositório:**
    Comece abrindo o seu terminal ou Git Bash.
    ```bash
    git clone https://github.com/loppnowcd/movie-api-dotnet-challange.git
    cd movie-api-dotnet-challange
    ```
2.  **Restaure as dependências:**
    Dentro da pasta do projeto, execute o comando para restaurar todos os pacotes NuGet necessários.
    ```bash
    dotnet restore
    ```
3.  **Configure a Chave da API:**
    - A API utiliza o The Movie Database (TMDb) para buscar dados. Você precisará de uma chave de API pessoal obtida no portal de desenvolvedor deles.
    - Para manter sua chave segura, usamos um arquivo separado para o ambiente de desenvolvimento local. Dentro da pasta `MovieApi`, crie um novo arquivo chamado `appsettings.Development.json`.
    - Agora, basta colar sua chave da API neste arquivo. Ele deve ter a seguinte estrutura:
    ```json
    {
      "ApiSettings": {
        "MovieDbApiKey": "SUA_CHAVE_AQUI"
      }
    }
    ```
    *(Dica: Lembre-se de substituir "SUA_CHAVE_AQUI" pela sua chave real!)*
4.  **Execute as Migrations:**
    - Este é um passo crucial! Ele vai criar o banco de dados e a tabela `Movies` para você. Não se preocupe em escrever queries SQL.
    - No seu terminal, certifique-se de estar na pasta do projeto (`MovieApi/MovieApi`) e execute o comando abaixo.
    ```bash
    dotnet ef database update
    ```

5.  **Execute a aplicação:**
    - Estamos quase lá! Execute o comando abaixo para iniciar a API.
    ```bash
    dotnet run --project MovieApi/Api/MovieApi.Api.csproj
    ```
    - A API estará disponível em `https://localhost:7000`. Você verá uma mensagem de confirmação no terminal.

## Endpoints da API: Um Teste Rápido

Agora que a API está em funcionamento, vamos testá-la usando o Swagger. Você vai adorar!

1.  **Abra o Swagger:**
    - Abra seu navegador e navegue para `https://localhost:7000/swagger`.
    - Você verá a documentação da nossa API.
  
2.  **Busque e Salve Filmes:**
    - Procure pelo endpoint `GET /api/Movie/fetch-and-save-popular-movies`.
    - Clique nele, depois clique no botão "Try it out".
    - Por fim, clique em "Execute". Você verá a mágica acontecer! Sua API irá chamar o TMDb, obter os filmes e salvá-los diretamente no seu banco de dados.

## Documentação da API de Terceiros

- [Documentação da API do The Movie Database (TMDb)](https://developers.themoviedb.org/3)
