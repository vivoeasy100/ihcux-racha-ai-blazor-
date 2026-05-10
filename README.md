# RachaAí - Dashboard de Finanças Coletivas (IHC & UX)

Este projeto é parte da Lista de Exercícios XVI da disciplina de Interação Humano Computador e UX do Centro Universitário UNA.

## 🚀 Implementação Blazor

Para transpor a hierarquia visual do Miro para os componentes Blazor, seguimos os seguintes princípios de UX:

1.  **Heurística de Visibilidade do Status do Sistema**: No topo do dashboard, utilizamos cards de resumo com cores contrastantes (Azul para Saldo, Verde para Receber e Vermelho para Pagar). Isso permite que o usuário identifique instantaneamente sua situação financeira global.
2.  **Agrupamento e Proximidade**: A lista de grupos utiliza o componente customizado `GrupoCard.razor`, que organiza as informações essenciais (nome, categoria e valor) de forma compacta e clara, facilitando a leitura por varredura.
3.  **Affordance e Feedback**: Os cards de grupo possuem efeitos de hover e sombras sutis para indicar que são elementos interativos. O botão de ação rápida (FAB) no mobile segue os padrões modernos de design para facilitar a inserção de novos dados.
4.  **Consistência Visual**: Utilizamos uma paleta de cores baseada no Bootstrap para manter a consistência com o rascunho inicial, garantindo que o "Vermelho" sempre indique dívida e o "Verde" indique crédito.

## 🛠️ Desafios Técnicos

### Qual foi o maior desafio ao componentizar o `GrupoCard`?

O maior desafio técnico foi garantir que o componente fosse altamente flexível para diferentes estados financeiros (positivo/negativo) sem poluir o código da página principal. A lógica condicional dentro do componente para alternar entre as classes `text-danger` e `text-success` baseada na propriedade `NoVermelho` permitiu uma separação clara de responsabilidades, facilitando a manutenção e a reutilização do código em outras partes do sistema.

## ✨ Recursos Adicionais (Desafio Extra)

Implementamos um **campo de busca em tempo real** que filtra a lista de grupos conforme o usuário digita. Utilizamos o binding `@bind-value:event="oninput"` para garantir uma resposta imediata da interface, melhorando a experiência de busca e localização de informações.

---
**Professor:** Daniel Henrique Matos de Paiva  
# Adicionar todas as mudanças atuais (incluindo as exclusões locais)
git add .

# Criar um commit com a versão final e limpa
git commit -m "Final version: Optimized C# logic and clean structure"

# Forçar o envio para o GitHub, substituindo tudo o que estiver lá
git push -u origin main --force
Instituição:** Centro Universitário UNA
Aluno - Fernando Almeida
<img width="1373" height="775" alt="image" src="https://github.com/user-attachments/assets/cd8fcb7a-0b7b-466c-a5b7-e886d2e6b7d0" /><img width="1373" height="775" alt="image" src="https://github.com/user-attachments/assets/48bcc195-520e-41e7-a7bc-0517082eb0c8" />

