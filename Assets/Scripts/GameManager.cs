// GameManager.cs
// Script de nueva creación: controla y muestra la puntuación en pantalla

using UnityEngine;
using TMPro; // Para TextMeshPro

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI scoreText;   // Referencia al texto de UI
    private int score = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    // cuando el jugador recolecta una antorcha suma puntos
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = "Puntos: " + score.ToString();
    }
}
