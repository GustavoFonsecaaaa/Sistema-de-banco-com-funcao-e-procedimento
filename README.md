# 🏧 Simulador de Caixa Eletrônico (ATM)

> Projeto de estudo prático desenvolvido para a disciplina de Algoritmos e Técnicas de Programação (ATP).

Este é um projeto de aplicação Console em **C#** que simula as operações básicas de um caixa eletrônico. O foco principal deste exercício foi consolidar o entendimento sobre **manipulação de estado de variáveis** (atualizar o saldo) utilizando o retorno de funções.

## 💻 Funcionalidades

O sistema possui um menu interativo (`do...while`) com as seguintes opções:

- **💰 Depositar:**
  - Solicita um valor ao usuário.
  - Utiliza uma **Função** para somar o valor ao saldo atual.
  - Retorna e atualiza o novo saldo na variável principal.

- **💸 Sacar:**
  - Verifica se há saldo suficiente para o saque (`if/else`).
  - Se aprovado, subtrai o valor e retorna o saldo atualizado.
  - Se negado, exibe mensagem de "Saldo Insuficiente" e mantém o saldo original.

- **📊 Ver Saldo:**
  - Utiliza um **Procedimento** (`void`) apenas para formatar e exibir o saldo na tela, demonstrando a diferença entre calcular dados e exibir dados.

## 🛠️ Conceitos Praticados

- **Modularização:** Separação clara entre Lógica de Negócio (Funções) e Interface/Exibição (Procedimentos).
- **Retorno de Valores:** Uso do comando `return` para persistir cálculos feitos dentro de métodos auxiliares.
- **Controle de Fluxo:** Uso de `do...while` para manter o menu ativo e `if/else` para validação de saque.
- **Entrada e Saída:** Manipulação de `Console.ReadLine` e `Console.WriteLine`.

## 🚀 Como rodar o projeto

1. Certifique-se de ter o **.NET SDK** instalado.
2. Clone este repositório:
   ```bash
   git clone [https://github.com/SEU-USUARIO/NOME-DO-REPO.git](https://github.com/SEU-USUARIO/NOME-DO-REPO.git)

   Desenvolvido por Gustavo Venâncio Fonseca Estudante de Análise e Desenvolvimento de Sistemas - PUC Minas