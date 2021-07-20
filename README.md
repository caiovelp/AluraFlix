<h1 align="center">
    Aluraflix - Alura Challenge Backend
</h1>

## :page_with_curl: Sobre
API criada na **Alura Challenge de BackEnd** em que o objetivo é desenvolver uma plataforma para compartilhamento de vídeos. A plataforma deve deve permitir ao usuário montar playlists com links para seus vídeos preferidos, separados por categorias.

## :desktop_computer: Tecnologia Usadas
| Nome                                          |Versão         |
| -------------                                 |:-------------:|
| [C#](https://dotnet.microsoft.com/)           |   9.0         |
| [ASP.Net CORE](https://dotnet.microsoft.com/) |   5.0         |
| [MySQ](https://www.mysql.com/)                |   8.0         |

## :card_index_dividers: Trello Cards - Desafios
### Semana 1
- [x] Banco de dados
- [x] Requisição POST
- [x] Requisição PUT/PATCH
- [x] Requisição GET
- [x] Requisição GET por ID
- [x] Requisição DELETE
- [x] Testes no Postman
- [x] Regra de negócio

## :rocket: Como executar esse Projeto ?
1. Abra o Visual Studio e na tela inicial selecione a opção de clonar o repositório.
2. No campo "Local do Repositório" insira o repositório: https://github.com/caiovelp/AluraChallenge.git e clique em Clonar.
3. Seleciona a solução AluraChallenge.sln para visualizar os arquivos. Todos os pacotes já são instalados automaticamente, basta conferir no Gerenciador de Pacotes do NuGet.

### Configurando o MySQL
Como o user=root e password=root, definido por padrão, basta se atentar à esses parâmetros. No arquivo _**appsetting.json**_ dentro da solução, é possível mudar esses parâmetros na linha 'VideoConnection'.
