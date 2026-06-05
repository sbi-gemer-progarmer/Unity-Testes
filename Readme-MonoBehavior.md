O ciclo de vida de um script no Unity é dividido em quatro blocos principais de execução: 

* Inicialização
* Física
* Lógica de Jogo (Game Loop)
* Desativação

## 1. Inicialização (Rodam apenas uma vez)

### Awake
```csharp
void Awake (){...}
```

* __Quando roda__: Assim que o objeto é carregado na memória, mesmo que o componente esteja desativado.
* __Para que serve__: Ideal para buscar referências (`GetComponent`) e inicializar variáveis locais.

### OnEnable

```csharp
void OnEnable (){...}
```
* __Quando roda__: Sempre que o objeto ou o componente muda do estado desativado para ativo. Roda logo após o `Awake` na primeira vez.
* __Para que serve__: Ativar eventos, escutar inputs ou reiniciar configurações quando o objeto reaparece no jogo.

### Start

```csharp
void Start (){...}
```

* __Quando roda__: Apenas no primeiro frame de vida do script, logo antes de qualquer atualização visual, mas apenas se o script estiver ativo.
* __Para que serve__: Passar dados de um script para outro, pois garante que todos os Awake de outros objetos já rodaram.

## 2. Ciclo de Física (Rodam a uma taxa fixa)

Ao contrário dos frames visuais, que oscilam conforme o desempenho do computador, o ciclo de física precisa de precisão constante.

### FixedUpdate

* __Quando roda__: Em intervalos de tempo constantes e pré-definidos (por padrão, a cada 0.02 segundos), independente da taxa de quadros (FPS).
* __Para que serve__: Toda a lógica de física que envolve `Rigidbody`, forças (`AddForce`) ou verificação de colisões deve ser feita aqui.

## 3. Ciclo de Jogo e Renderização (Rodam a cada Frame)

Estas funções dependem diretamente do FPS do computador do jogador. Se o jogo roda a 60 FPS, elas executam 60 vezes por segundo.

### Update

* __Quando roda__: Uma vez por frame de renderização. É a função mais utilizada no Unity.
* __Para que serve__: Captura de botões do teclado/controle (Input), temporizadores (Timers) e movimentações simples que não usam física.

### LateUpdate

* __Quando roda__: Uma vez por frame, mas garantidamente depois que todas as funções Update de todos os scripts da cena já terminaram.
* __Para que serve__: Movimentação e rotação de câmeras. Como o personagem se moveu no `Update`, a câmera o segue no `LateUpdate` para evitar tremores na imagem.

## 4. Desativação e Destruição (Fim da vida)

Funções executadas quando o ciclo do objeto chega ao fim.

### OnDisable

* __Quando roda__: Sempre que o componente ou o objeto é desativado.
* __Para que serve__: Desvincular eventos e limpar listeners para evitar vazamento de memória.

### OnDestroy

* __Quando roda__: No último frame de vida do objeto, logo após ser deletado via código (`Destroy(gameObject)`) ou quando a cena muda.
* __Para que serve__: Limpeza final de dados e salvamento de estados pontuais.

## Ordem Cronológica

```text
[Objeto Nasce] ➔ Awake() ➔ OnEnable() ➔ Start() 
   │
   ├─► Loop Fixo: FixedUpdate() (Física - ex: 50x por segundo)
   │
   ├─► Loop Visual: Update() ➔ LateUpdate() (Gráficos - ex: 60x por segundo)
   │
[Objeto Morre] ➔ OnDisable() ➔ OnDestroy()

```
