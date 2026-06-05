# Desenvolvimento Unity

## Tópicos

`Fan Gaming` `FNAF` `Point And Click`

## Métodos

```csharp

void Update(){}

```

## Corpo do script c# no Unity

```csharp
using UnityEngine; // Importação da biblioteca

public class Camera : MonoBehaviour // Classe denominada de "Camera"
{
    public Transform tr; // Variável publica do tipo Transform
    public float tempo = 0.0f;
    private Vector3 velocidade = Vector3.zero; // Variável privada de 3 vetores (x, y ,z)

    void LateUpdate()
    {
        // Corpo da função
    }
}
```

## Movimentação da Câmera

`Vector3` `Lerp (Interpolação Linear)` `Slerp (Interpolação Esférica)`

> ### Lerp:
> 
> transição que começa rápida e vai desacelerando conforme se aproxima do destino
> 
> ```csharp
> // Variáveis
> public Transform alvo;
> public float velocidade = 5f;
> ```
> 
> ```csharp
> // Em LateUpdate:
> // Posição alvo com um deslocamento (offset) no eixo Z
> Vector3 posicaoDesejada = new Vector3(alvo.position.x, alvo.position.y, -10f);
> 
> // Interpolação linear da posição atual para a posição desejada
> transform.position = Vector3.Lerp(transform.position, posicaoDesejada, velocidade * Time.deltaTime);
> ```

> ### Slerp:
> 
> Câmeras em terceira pessoa que orbitam o personagem
> 
> ```csharp
> // Variáveis
> public Transform alvo;
> public float velocidadeRotacao = 2f;
> ```
> 
>```csharp
> // Em LateUpdate():
> Vector3 posicaoDesejada = alvo.position + new Vector3(0, 5, -10);
> 
> // Movimento em arco (esférico)
> transform.position = Vector3.Slerp(transform.position, posicaoDesejada, velocidadeRotacao * Time.deltaTime);
> 
> // Faz a câmera olhar para o jogador
> transform.LookAt(alvo);
> ```

> ### SmoothDamp
>
> Suavização baseada em física que elimina a "parada brusca"
>
> ```csharp
> public Transform alvo;
> public float tempoSuave = 0.3f;
> private Vector3 velocidadeAtual = Vector3.zero;
> 
> void LateUpdate()
> {
>     Vector3 posicaoDesejada = alvo.position + new Vector3(0, 2, -10);
>     
>     // Move suavemente com velocidade ajustável sem ter picos de frenagem
>     transform.position = Vector3.SmoothDamp(transform.position, posicaoDesejada, ref velocidadeAtual, tempoSuave);
> }
> ```
