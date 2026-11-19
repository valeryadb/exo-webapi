# Exo.WebApi: API de Projetos da ExoApi

Atividade **SP1 – Atividade 3: Criar estrutura da API com Context e método GET para projetos, teste no navegador** (Desenvolvimento de APIs, SENAI-DF).

API REST em **ASP.NET Core** com **Entity Framework Core** e **SQL Server** que lista os projetos cadastrados no banco de dados da ExoApi.

## ✅ Endpoint

| Método | Rota | Descrição | Resposta |
|---|---|---|---|
| GET | `/api/projetos` | Lista todos os projetos (id, nome do projeto, área e status) | `200 OK` com JSON |

Exemplo de resposta:
```json
[
  { "id": 1, "nomeDoProjeto": "Projeto A - Obras BR", "area": "Construção Civil", "status": true },
  { "id": 2, "nomeDoProjeto": "Projeto B - SENAI Fest", "area": "Eventos", "status": false },
  { "id": 3, "nomeDoProjeto": "Projeto C - Hackathon Fest", "area": "Eventos", "status": true }
]
```

## 📂 Estrutura

| Pasta | Classe | Função |
|---|---|---|
| Contexts | `ExoContext.cs` | Conexão com o banco de dados (Entity Framework) |
| Models | `Projeto.cs` | Atributos da entidade Projeto |
| Repositories | `ProjetoRepository.cs` | Acesso aos dados (padrão Repository) |
| Controllers | `ProjetosController.cs` | Recebe as requisições HTTP e devolve as respostas |

## ▶️ Como executar

1. No **SSMS**, abra e execute o `cria-db.sql` para criar o banco `ExoApi` com os projetos e usuários.
2. Confira a string de conexão em `Contexts/ExoContext.cs` (padrão: `Server=localhost\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;`).
3. No terminal, dentro da pasta do projeto:
```bash
dotnet restore
dotnet run
```
4. No navegador, acesse o endereço exibido no terminal + `/api/projetos` (ex.: `http://localhost:5038/api/projetos`).

## 🛠️ Tecnologias
C# · ASP.NET Core Web API · Entity Framework Core 6 · SQL Server

## 👩‍💻 Autora
Valerya Dias · [GitHub](https://github.com/valeryadb) · [LinkedIn](https://linkedin.com/in/valerya-dias)
