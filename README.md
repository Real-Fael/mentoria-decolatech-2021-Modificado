# Projeto modificado Bootcamp DecolaTech-2021 Avanade 

O projeto tem como objetivo principal aplicar os conceitos de OO na prática, utilizando a temática de uma conta bancária onde é possível depositar, sacar, criar contas e ter acesso a um simples extrato.

Modifiquei o projeto original criando uma Classe MeuBanco, onde o mesmo tem controle e pode gerenciar diversas contas, além de possibilitar fazer transferências, tentei implementar de forma a não precisar mexer no projeto inicial, somente onde foi encontrado problemas, tentando aplicar o Open-closed principle. 

Desenvolvi também uma Classe chamada UserInterface para implementar uma interface console para interagir com o usuário.

Para executar o projeto entre no diretório AgenciaBancaria.App que é a responsável pela interface do projeto e utilize o comando. 
- `dotnet run` 

Teste e se encontrar erros por favor me contate.


# Objetivo
Observar os pilares da orientação a objetos (abstração, encapsulamento, herança e polimorfismo) interpretando e implementando um domínio de negócio “Agência bancária”.

# Domínio
Simulação do contexto de uma agência bancária, fluxo de abertura de conta e utilização da conta aberta.

# Referências
- DDD e microservices:
  - https://medium.com/cwi-software/domain-driven-design-do-in%C3%ADcio-ao-c%C3%B3digo-569b23cb3d47
  - https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/net-core-microservice-domain-model
- POCO classes: https://www.eduardopires.net.br/2012/10/classes-poco/
- Operadores: https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/
- ValueObject: https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/implement-value-objects

# Pilares da Orientação a Objetos
## Abstração
- Representação de objetos reais
-	Simplifica um problema difícil, dividindo em partes menores
-	Partes independentes com responsabilidade definida
-	Reaproveitamento de código

## Encapsulamento 
-	Ocultar detalhes internos das partes
-	Visualização do objeto como uma caixa preta
-	Você sabe o que faz (Interface)
-	Não sabe como ela faz (Implementação)

## Herança
-	Criar nova classe a partir de uma existente
-	Herda atributos
-	Herda comportamentos
-	Herda implementações

## Polimorfismo
-	Polimorfismo – muitas formas
-	Único nome – diferentes comportamentos
- “Abrir”
   - Uma porta
   - Uma caixa
   - Uma janela
   - Uma conta bancária

