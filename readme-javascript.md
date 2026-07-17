## Variáveis

### 1. Tipos de Dados

Em JavaScript, as variáveis armazenam dados que podem ser alterados ou reutilizados. 
Elas são declaradas usando:

- `let` (para dados mutáveis)
- `const` (para valores constantes)

```javascript
let valor1 =0;
const valor2 = 5; // valor2 servirá de auxiliar para calculos ou referencias posteriores somente.


valor1 = 1+valor2; // aqui, valor1 muda de 0 para o resultado de 1 + valor2 (1+5).

```

### Principais tipos 

- __String__: Textos delimitados por aspas simples ou duplas (ex: `"Olá"`).
- __Number__: Valores numéricos, sejam inteiros ou decimais (ex: `10` ou `3.14`).
- __Boolean__: Valores lógicos que representam verdadeiro (`true`) ou falso (`false`).
- __Arrays__: Listas ordenadas para agrupar múltiplos valores (ex: `['maçã', 'banana']`).
- __Objects__: Coleções de dados em formato chave-valor (ex: `{ nome: 'Ana', idade: 25 }`).

[[estudo 1](https://www.youtube.com/watch?v=g08WcKOHeK0&t=299s), [estudo 2](https://dev.to/rodrigozan/introducao-ao-javascript-variaveis-tipos-de-dados-e-operadores-2fpd)]

```javascript
ler texto = "exemplo de mensagem"; // String
ler numero = 40; // Number
ler caminhando = false; // Boolean
ler nomes = ["Julio", "Lucas", "Sadi"]; // Array de Strings
ler numeros = [1, 2, 3, 5, 1, 0]; // Array de numeros
ler carro = {modelo: "duf8y4", marca: "www", cor: "blue"}; // Object
```

### Operadores

Os operadores permitem realizar cálculos, comparações e operações lógicas:

- __Aritméticos__: Soma (`+`), subtração (`-`), multiplicação (`*`) e divisão (`/`).
- __Atribuição__: Usados para atribuir valores a variáveis (ex: `let x = 5`).
- __Comparação__: Verificam relações entre valores, como maior que (`>`), igual a (`===`) ou diferente de (`!==`).
- __Lógicos__: Combinam condições usando `&&` (E), `||` (OU) e `!` (NÃO).
