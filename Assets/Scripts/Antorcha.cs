// Script para recolecta la antorcha y da puntos al jugador

using UnityEngine;

public class Antorcha : MonoBehaviour
{
    public int puntos = 10; // cada antorcha da 10 puntos

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            // Sumar puntos al jugador
            GameManager.instance.AddScore(puntos);

            // Destruir la antorcha cuando el jugador la recolecta
            Destroy(gameObject);
        }
    }
}
