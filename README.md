# Teste de Desenvolvimento 1 - Estágio

Aplicação desktop desenvolvida em C# (Windows Forms) com PostgreSQL, como parte do processo seletivo da empresa Cervantes.

## ✔️ Funcionalidade

- Cadastro de registros com:
  - Campo texto (nome)
  - Campo numérico (> 0 e único)

## ✅ Regras e Validações

- Todos os campos são obrigatórios
- Validações implementadas no banco (NOT NULL, UNIQUE, > 0)
- Log de operações (INSERT) com data/hora via trigger

## 📁 Estrutura

- `/CadastroLayout` – Código-fonte (Windows Forms)
- `/banco/queryTeste1.sql` – Script de criação do banco e trigger
- `/executavel` – Aplicação compilada

---

Desenvolvido por **Lucas Lima**.
