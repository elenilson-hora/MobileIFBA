using UnityEngine;
using UnityEngine.InputSystem;

public class UI_HomeworkOne : MonoBehaviour
{
    //Crie um cenário com um player qualquer e uma chão e implemente a
    //movimentação do player através de 4 botões(Cima, baixo, esquerda e direita) usando o new input system via Polling.
    //Depois implemente o pulo via botão e via new input system usando PalyerInput(Unity events).
    //Façam esse pulo só com a programação da mecânica de pulo(sem a callback para pegar a Phase do evento).

    // Input System
    private InputAction moveAction;

    // Unity
    private CharacterController cc;
    private Rigidbody rb;

    private Vector3 velocity;
    private Vector2 vector2;

    // C#
    private float speed = 10f;

    // MonoBehaviour
    private void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");

        cc = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        vector2 = moveAction.ReadValue<Vector2>();

        rb.AddForce(new Vector3(vector2.x, 0f, vector2.y) * speed);
    }

    private void OnJump(InputValue inputValue)
    {
        //Debug.Log("Jump");

        rb.AddForce(new Vector3(0f, 100f, 0f));
    }
}
