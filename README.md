# APIAutoMapper

Este projeto é uma API ASP.NET Core que utiliza AutoMapper para mapear objetos entre diferentes camadas da aplicação.

## Requisitos

- .NET 6.0
- AutoMapper 12.0.1
- AutoMapper.Extensions.Microsoft.DependencyInjection 12.0.0
- Swashbuckle.AspNetCore 6.5.0

## Pacotes NuGet

Os seguintes pacotes NuGet são utilizados neste projeto:

- `AutoMapper` - Biblioteca para mapeamento de objetos.
- `AutoMapper.Extensions.Microsoft.DependencyInjection` - Extensões para integrar o AutoMapper com o ASP.NET Core.
- `Swashbuckle.AspNetCore` - Ferramentas para gerar documentação Swagger para APIs ASP.NET Core.
- `Swashbuckle.AspNetCore.Swagger` - Geração de documentação Swagger.
- `Swashbuckle.AspNetCore.SwaggerGen` - Geração de documentação Swagger.
- `Swashbuckle.AspNetCore.SwaggerUI` - Interface de usuário para visualizar a documentação Swagger.

## Estrutura do Projeto

- `Controllers/CarrosController.cs` - Controlador responsável por gerenciar as operações relacionadas aos carros.
- `Modelos/Carro.cs` - Modelo de dados para representar um carro.
- `Modelos/EntradaDadosCarro.cs` - Modelo de dados para entrada de informações de um carro.
- `Modelos/SaidaDeDadosCarro.cs` - Modelo de dados para saída de informações de um carro.
- `Modelos/TipoCarro.cs` - Enumeração para os tipos de carro.
- `Mapeamentos/CarroMapper.cs` - Configuração de mapeamento do AutoMapper para os modelos de carro.
- `Program.cs` - Configuração e inicialização da aplicação.

## Endpoints

- `GET /api/Carros` - Retorna todos os carros.
- `GET /api/Carros/{id}` - Retorna um carro pelo ID.
- `POST /api/Carros` - Salva um novo carro.

## Como Executar

1. Clone o repositório.
2. Navegue até o diretório do projeto.
3. Execute o comando `dotnet restore` para restaurar as dependências.
4. Execute o comando `dotnet run` para iniciar a aplicação.
5. Acesse `https://localhost:5001/swagger` para visualizar a documentação Swagger.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests.

## Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
