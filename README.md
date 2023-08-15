# Exemplo Básico de Arquitetura Hexagonal (Portas e Adaptadores)

Este repositório contém um exemplo simples de como implementar a arquitetura hexagonal (também conhecida como arquitetura de portas e adaptadores) em uma aplicação C# .NET 7 Core.

## O que é a arquitetura hexagonal?

A arquitetura hexagonal é um padrão arquitetural que visa separar a lógica de negócios do sistema das preocupações técnicas, como a interface com o usuário ou o acesso a banco de dados. Ela é baseada na ideia de que uma aplicação é composta por "portas" de entrada e saída, que permitem a comunicação com o mundo exterior, e "adaptadores", que se encarregam de converter essas informações em algo que a aplicação possa entender e vice-versa.

## Como este exemplo está organizado?

Este exemplo foi construído usando C# e está dividido em dois módulos:

- `Core`: este módulo contém a camada de aplicação, que é responsável por orquestrar o fluxo de dados e regras de negócio da aplicação. Aqui estão as classes que implementam os casos de uso da aplicação.

- `Adapters`: este módulo contém a camada de infraestrutura, que é responsável pela comunicação com o mundo exterior. Aqui estão as classes que implementam as portas de entrada e saída da aplicação, bem como os adaptadores necessários para se comunicar com diferentes tecnologias.

## Conclusão

Este é um exemplo simples de como implementar a arquitetura hexagonal em uma aplicação C# .NET 7 Core. É importante notar que este exemplo é apenas uma demonstração básica do conceito e que a implementação real de uma aplicação usando este padrão pode ser mais complexa e exigir mais camadas e adaptações. No entanto, espero que este exemplo possa ser útil para quem está interessado em aprender mais sobre este padrão arquitetural.
