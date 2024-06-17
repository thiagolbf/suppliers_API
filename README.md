#### API para gerenciamento de fornecedores com seus produtos

#### API de Fornecedores x Produtos criada em camadas:  API / Business / Data
#### Fornecedor poderá cadastrar seus produtos e sua localidade onde: Fornecedor 1:1 Localidade ; Fornecedor 1:N Produtos

#### Tecnologias utilizadas;

- C#
- EntityFramework
- FluentValidation
- SQLServer
- Swagger (para documentação da API)

#### Endpoints

#### Fornecedores

| Método | Endpoint                   | Responsabilidade                                  |
| ------ | -------------------------- | ------------------------------------------------- |
| POST   | /api/fornecedores          | Criação de fornecedor                             |
| GET    | /api/fornecedores          | Lista todos fornecedores                          |
| GET    | /api/fornecedores/{id}     | Lista um fornecedor específico                    |
| PUT    | /api/fornecedores/{id}     | Atualiza um fornecedor                            |
| DELETE | /api/fornecedores/{id}     | Deleta um fornecedor                              |

#### Produtos

| Método | Endpoint                   | Responsabilidade                                  |
| ------ | -------------------------- | ------------------------------------------------- |
| POST   | /api/produtos              | Criação de produto                                |
| GET    | /api/produtos              | Lista todos produtos                              |
| GET    | /api/produtos              | Lista um produto específico                       |
| PUT    | /api/produtos/{id}         | Atualiza um produto                               |
| DELETE | /api/produtos/{id}         | Deleta um produto                                 |



