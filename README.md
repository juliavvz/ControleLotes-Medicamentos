# 💊 Sistema de Controle de Medicamentos (Filas)

Projeto desenvolvido para a disciplina de **Estrutura de Dados 2 (CBTEDD2)** do **IFSP - Campus Cubatão**.

O sistema é uma aplicação de console em C# que gerencia o estoque de medicamentos de uma farmácia utilizando a estrutura de dados **Fila (`Queue<T>`)** para controlar os lotes por ordem de vencimento (FIFO - *First In, First Out*).

---

## 🚀 Funcionalidades

1. **Cadastrar medicamento**
2. **Consultar medicamento (sintético):** Exibe id, nome, laboratório e quantidade total disponível.
3. **Consultar medicamento (analítico):** Exibe os dados do medicamento junto com os detalhes de cada lote em estoque.
4. **Comprar medicamento (cadastrar lote):** Adiciona um novo lote na fila do medicamento correspondente.
5. **Vender medicamento:** Abate a quantidade desejada priorizando sempre o lote mais antigo (removendo lotes zerados automaticamente).
6. **Listar medicamentos:** Mostra todos os medicamentos cadastrados de forma sintética.

---

##  Tecnologias Utilizadas

* **Linguagem:** C# (.NET / Console Application)
* **Estruturas de Dados:** `List<T>`, `Queue<T>`, `DateTime`

---

##  Diagrama de Classes

* **`Lote`**: Controla o ID, a quantidade e a data de vencimento de cada lote.
* **`Medicamento`**: Gerencia as informações do remédio e armazena os lotes em uma `Queue<Lote>`.
* **`Medicamentos`**: Gerencia a lista geral de medicamentos cadastrados no sistema.

---

##  Autor
Desenvolvido para fins acadêmicos no curso de **Tecnologia em Análise e Desenvolvimento de Sistemas (TADS)**.
