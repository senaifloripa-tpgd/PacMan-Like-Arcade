using UnityEngine;
using UnityEngine.InputSystem; // Adicionando o namespace correto

public class PlayerTwo : MonoBehaviour
{
    public InputAction controlesJogador2;
    Vector2 direcaoMovimento;

    public float velocidadeJogador = 5f;
    public Rigidbody2D fisicaJogador;

    private void OnEnable()
    {
        controlesJogador2.Enable(); // Corrigido para usar controlesJogador2
    }

    private void OnDisable()
    {
        controlesJogador2.Disable(); // Corrigido para usar controlesJogador2
    }

    void Update()
    {
        direcaoMovimento = controlesJogador2.ReadValue<Vector2>();
        fisicaJogador.linearVelocity = new Vector2(direcaoMovimento.x * velocidadeJogador, direcaoMovimento.y * velocidadeJogador);
    }
    
    
}