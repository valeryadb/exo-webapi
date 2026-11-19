# Exo.WebApi: API de Projetos da ExoApi

Atividades da UC **Desenvolvimento de APIs** (SENAI-DF):
- **SP1 – Atividade 3:** estrutura da API com Context e método GET, teste no navegador
- **SP1 – Atividade 4:** restante do CRUD de projetos, teste no Insomnia
- **SP1 – Atividade 5:** CRUD de usuários

API REST em **ASP.NET Core** com **Entity Framework Core** e **SQL Server** com o CRUD completo de **projetos** e de **usuários** cadastrados no banco de dados da ExoApi.

## ✅ Endpoints

### Projetos

| Método | Rota | Descrição | Resposta |
|---|---|---|---|
| GET | `/api/projetos` | Lista todos os projetos (id, nome do projeto, área e status) | `200 OK` com JSON |
| GET | `/api/projetos/{id}` | Busca um projeto pelo id | `200 OK` ou `404 Not Found` |
| POST | `/api/projetos` | Cadastra um projeto (o id é gerado automaticamente) | `201 Created` |
| PUT | `/api/projetos/{id}` | Atualiza todas as informações de um projeto | `204 No Content` ou `404 Not Found` |
| DELETE | `/api/projetos/{id}` | Remove um projeto | `204 No Content` ou `404 Not Found` |

### Usuários
| Método | Rota | Descrição | Resposta |
|---|---|---|---|
| GET | `/api/usuarios` | Lista todos os usuários (id, e-mail e senha) | `200 OK` com JSON |
| GET | `/api/usuarios/{id}` | Busca um usuário pelo id | `200 OK` ou `404 Not Found` |
| POST | `/api/usuarios` | Cadastra um usuário | `201 Created` |
| PUT | `/api/usuarios/{id}` | Atualiza e-mail e senha de um usuário | `204 No Content` ou `404 Not Found` |
| DELETE | `/api/usuarios/{id}` | Remove um usuário | `204 No Content` ou `404 Not Found` |

Exemplo de resposta do `GET /api/projetos`:
```json
[
  { "id": 1, "nomeDoProjeto": "Projeto A - Obras BR", "area": "Construção Civil", "status": true },
  { "id": 2, "nomeDoProjeto": "Projeto B - SENAI Fest", "area": "Eventos", "status": false },
  { "id": 3, "nomeDoProjeto": "Projeto C - Hackathon Fest", "area": "Eventos", "status": true }
]
```

Exemplos de corpo (JSON) para `POST` e `PUT`:
```json
{ "nomeDoProjeto": "Projeto D - Senai FIT", "area": "Saúde", "status": true }
```
```json
{ "email": "email_tres@sp.br", "senha": "1234" }
```

## 🧪 Testes no Insomnia / Postman
O arquivo `ExoApi-Insomnia-Postman.json` traz as requisições prontas de projetos e de usuários (listar, cadastrar, buscar por id, atualizar, deletar e listar de novo).
No Insomnia: **Import > From File** e escolha o arquivo. Ajuste a variável `base_url` para o endereço exibido no `dotnet run`.

## 📂 Estrutura

| Pasta | Classe | Função |
|---|---|---|
| Contexts | `ExoContext.cs` | Conexão com o banco de dados (Entity Framework) |
| Models | `Projeto.cs`, `Usuario.cs` | Atributos das entidades Projeto e Usuário |
| Repositories | `ProjetoRepository.cs`, `UsuarioRepository.cs` | Acesso aos dados (padrão Repository) |
| Controllers | `ProjetosController.cs`, `UsuariosController.cs` | Recebem as requisições HTTP e devolvem as respostas |

## ▶️ Como executar

1. No **SSMS**, abra e execute o `cria-db.sql` para criar o banco `ExoApi` com os projetos e usuários.
2. Confira a string de conexão em `Contexts/ExoContext.cs` (padrão: `Server=localhost\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;`).
3. No terminal, dentro da pasta do projeto:
```bash
dotnet restore
dotnet run
```
4. No navegador ou no Insomnia, acesse o endereço exibido no terminal + `/api/projetos` (ex.: `http://localhost:5038/api/projetos`).

## 🛠️ Tecnologias
C# · ASP.NET Core Web API · Entity Framework Core 6 · SQL Server

## 👩‍💻 Autora
Valerya Dias · [GitHub](https://github.com/valeryadb) · [LinkedIn](https://linkedin.com/in/valerya-dias)
