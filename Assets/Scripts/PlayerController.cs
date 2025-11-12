// reutilizar el código de PlayerController2.cs
// Animaciones: Run, Jump, Attack1 y Death

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private Rigidbody2D rb;

    public float speed = 10.0f;
    // que no permite saltar más alto - mas que enemigos
    public float jumpForce = 20.0f;

    void Start()
    {
        // Obtener componentes
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Obtener input horizontal
        float moveHorizontal = Input.GetAxisRaw("Horizontal");

        // Movimiento horizontal usando linearVelocity
        Vector2 velocity = rb.linearVelocity;
        velocity.x = moveHorizontal * speed;
        rb.linearVelocity = velocity;

        // Correr - Actualizar animación de correr
        animator.SetBool("isRunning", moveHorizontal != 0);

        // Voltear - sprite según dirección
        if (moveHorizontal < 0) spriteRenderer.flipX = true; // izquierda
        else if (moveHorizontal > 0) spriteRenderer.flipX = false; // derecha

        // Saltar - Salto con la tecla espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            animator.SetBool("isJumping", true);
        }
        else if (rb.linearVelocity.y <= 0.01f)
        {
            animator.SetBool("isJumping", false);
        }

        // Atacar - con el tecla X
        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetTrigger("attackTrigger");
        }

        // Morir - con la tecla M
        if (Input.GetKeyDown(KeyCode.M))
        {
            animator.SetBool("isDead", true);
        }
    }
}

