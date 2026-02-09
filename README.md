# Products & Client Hub API

Uma API de gerenciamento de clientes e produtos desenvolvida para consolidar conhecimentos em **C#** e no ecossistema **.NET**. O projeto foi construído do zero com o objetivo de aplicar boas práticas de desenvolvimento backend e padrões RESTful.

## 📌 Sobre o Projeto
Este projeto faz parte de uma trilha de aprendizado focada em transição de stack e aprofundamento no desenvolvimento web com .NET. A API permite o gerenciamento completo de clientes e serve como base para um sistema de hub de produtos em expansão.

## 🛠️ Tecnologias Utilizadas
* **C#**
* **ASP.NET Core Web API**
* **Swagger/OpenAPI** (Para documentação dos endpoints)
* **Padrão de Use Cases** (Separação da lógica de negócio das Controllers)

## 🏗️ Estrutura do Projeto
A arquitetura do projeto está sendo organizada para garantir escalabilidade:
* **Controllers:** Gerenciam as requisições HTTP e rotas.
* **Communication:** Contém os DTOs (Data Transfer Objects) para `Requests` e `Responses`.
* **UseCases:** Camada onde a lógica de negócio é executada de forma isolada.
