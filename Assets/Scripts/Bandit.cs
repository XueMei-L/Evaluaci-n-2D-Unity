// // Script de nueva creación: el bandido desaparece cuando el jugador lo ataca
// using UnityEngine;

// public class Bandit : MonoBehaviour
// {
//     private bool isDead = false;

//     private void OnTriggerEnter2D(Collider2D collision)
//     {
//         // Si choca con el área de ataque del jugador
//         if (collision.CompareTag("Attack") && !isDead)
//         {
//             isDead = true;
//             Destroy(gameObject); // el bandido desaparece
//         }
//     }
// }

// Script de nueva creación: el bandido desaparece si el jugador lo ataca
using UnityEngine;

public class Bandit : MonoBehaviour
{
    public bool playerInRange = false; // Si el jugador está cerca

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    void Update()
    {
        // Si el jugador está cerca y pulsa X, el bandido desaparece
        if (playerInRange && Input.GetKeyDown(KeyCode.X))
        {
            Destroy(gameObject);
        }
    }
}
