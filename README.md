# ☕ Cafeteria Dev

**Checkpoint 2 | C# Development | Engenharia de Software - FIAP (3ESPS)**

Sistema desktop para registrar pedidos de uma cafeteria, calcular o valor das compras e consultar as vendas realizadas. O projeto foi desenvolvido em **C# com Windows Forms e .NET 10**, com foco em uma interface simples, código organizado e aplicação dos conceitos básicos de **Programação Orientada a Objetos (POO)**.

## Funcionalidades

- **Tela de abertura (Splash):** exibe uma barra de carregamento antes de abrir o sistema.
- **Menu principal:** navegação entre as telas de vendas e relatório.
- **Venda de cafés:** informa o cliente, escolhe o café, define a quantidade e seleciona chantilly opcional.
- **Cálculo do pedido:** calcula o valor total considerando quantidade e adicional.
- **Registro de vendas:** salva os pedidos em um arquivo `vendas.txt`.
- **Relatório de vendas:** permite visualizar os pedidos registrados e atualizar a listagem.

## Tecnologias utilizadas

- C#
- .NET 10 (`net10.0-windows`)
- Windows Forms
- Visual Studio
- Git e GitHub

## Cardápio

| Café | Preço unitário |
| --- | ---: |
| Café Expresso | R$ 6,00 |
| Cappuccino | R$ 9,00 |
| Café Latte | R$ 11,00 |
| Café Mocha | R$ 10,00 |

**Adicional:** chantilly por **R$ 3,00 por unidade**. Os valores são fictícios e podem ser alterados no método `ObterPreco()` em `FrmVenda.cs`.

## Estrutura do projeto

```text
CafeteriaDev_CP2/
├── CafeteriaDev.sln
├── CafeteriaDev/
│   ├── Models/
│   │   ├── PedidoCafe.cs
│   │   └── PedidoEspecial.cs
│   ├── Views/
│   │   ├── FrmSplash.cs
│   │   ├── FrmMenu.cs
│   │   ├── FrmVenda.cs
│   │   └── FrmRelatorio.cs
│   ├── Program.cs
│   └── CafeteriaDev.csproj
├── integrantes.txt
└── README.md
```

> Os formulários possuem também seus arquivos `.Designer.cs` e `.resx`, gerenciados pelo Windows Forms.

## Conceitos de POO

O projeto utiliza **classes, objetos, encapsulamento, construtores, herança e polimorfismo**.

- **`PedidoCafe`:** classe base com os dados do pedido e o método `CalcularTotal()`.
- **`PedidoEspecial`:** herda de `PedidoCafe` e sobrescreve `CalcularTotal()` para considerar o valor do chantilly.
- **Formulários (`Views`):** recebem os dados, criam os objetos e exibem as informações para o usuário.

## Como executar

**Requisitos:** Windows, Visual Studio com o componente **Desenvolvimento para desktop com .NET** e o **SDK .NET 10**.

1. Clone o repositório ou baixe o projeto em ZIP.
2. Abra o arquivo **`CafeteriaDev.sln`** no Visual Studio.
3. Aguarde o carregamento da solução.
4. Pressione **F5** para iniciar.
5. Aguarde a tela de abertura e utilize o menu para registrar vendas ou consultar o relatório.

Para clonar o repositório informado para o projeto:

```bash
git clone https://github.com/maarcioherobrine25-source/Cafeteria_Dev.git
cd Cafeteria_Dev
```

## Como utilizar

1. No menu principal, clique em **Nova venda**.
2. Informe o nome do cliente, escolha o café e a quantidade.
3. Se desejar, marque a opção de **chantilly**.
4. Clique em **Calcular** para conferir o valor.
5. Clique em **Registrar venda** para salvar o pedido.
6. Volte ao menu e abra **Relatório de vendas** para consultar os registros.

**Exemplo:** 2 cafés Latte com chantilly = **R$ 28,00**.

### Armazenamento dos dados

As vendas são armazenadas localmente no arquivo `vendas.txt`, criado automaticamente na pasta em que o programa está sendo executado. Em uma execução padrão de desenvolvimento, o caminho costuma ser:

```text
CafeteriaDev/bin/Debug/net10.0-windows/vendas.txt
```
