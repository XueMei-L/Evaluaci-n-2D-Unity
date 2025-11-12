// // PlayerController2.cs
// // Script de nueva creación: controla al personaje principal usando los ejes estándar
// // Gestiona animaciones: Run, Jump, Attack1 y Death

// using UnityEngine;

// public class PlayerController2 : MonoBehaviour
// {
//     private SpriteRenderer spriteRenderer;
//     private Animator animator;
//     private Rigidbody2D rb;

//     public float speed = 10.0f;
//     public float jumpForce = 7.0f;

//     void Start()
//     {
//         // Obtener componentes
//         spriteRenderer = GetComponent<SpriteRenderer>();
//         animator = GetComponent<Animator>();
//         rb = GetComponent<Rigidbody2D>();
//     }

//     void Update()
//     {
//         // Obtener input horizontal
//         float moveHorizontal = Input.GetAxisRaw("Horizontal");

//         // Movimiento horizontal usando linearVelocity
//         Vector2 velocity = rb.linearVelocity;
//         velocity.x = moveHorizontal * speed;
//         rb.linearVelocity = velocity;

//         // Correr - Actualizar animación de correr
//         animator.SetBool("isRunning", moveHorizontal != 0);

//         // Voltear - sprite según dirección
//         if (moveHorizontal < 0) spriteRenderer.flipX = true; // izquierda
//         else if (moveHorizontal > 0) spriteRenderer.flipX = false; // derecha

//         // Saltar - Salto con la tecla espacio
//         if (Input.GetKeyDown(KeyCode.Space))
//         {
//             rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
//             animator.SetBool("isJumping", true);
//         }
//         else if (rb.linearVelocity.y <= 0.01f)
//         {
//             animator.SetBool("isJumping", false);
//         }

//         // Atacar - con el tecla F
//         if (Input.GetKeyDown(KeyCode.F))
//         {
//             animator.SetTrigger("attackTrigger");
//         }

//         // Morir - con la tecla M
//         if (Input.GetKeyDown(KeyCode.M))
//         {
//             animator.SetBool("isDead", true);
//         }
//     }
// }

// PlayerController2.cs
// Script de nueva creación: controla al personaje principal usando los ejes estándar
// Gestiona animaciones: Run, Jump, Attack1 y Death

// PlayerController2.cs
// Script de nueva creación: controla al personaje principal usando los ejes estándar
// Gestiona animaciones: Run, Jump, Attack1 y Death

using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private Rigidbody2D rb;

    public float speed = 10.0f;      // Velocidad de movimiento horizontal
    public float jumpForce = 7.0f;   // Fuerza del salto

    void Start()
    {
        // Obtener componentes
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimiento horizontal usando los ejes estándar
        float moveHorizontal = Input.GetAxisRaw("Horizontal");

        // Aplicar movimiento horizontal con linearVelocity
        Vector2 velocity = rb.linearVelocity;
        velocity.x = moveHorizontal * speed;
        rb.linearVelocity = velocity;

        // Animación de correr
        animator.SetBool("isRunning", moveHorizontal != 0);

        // Voltear sprite según dirección
        if (moveHorizontal < 0) spriteRenderer.flipX = false; // izquierda
        else if (moveHorizontal > 0) spriteRenderer.flipX = true; // derecha

        // Salto con Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            animator.SetBool("isJumping", true);
        }
        else if (rb.linearVelocity.y <= 0.01f)
        {
            animator.SetBool("isJumping", false);
        }

        // Ataque con J
        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("attackTrigger");
        }

        // Muerte con K (solo ejemplo)
        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetBool("isDead", true);
        }
    }
}
