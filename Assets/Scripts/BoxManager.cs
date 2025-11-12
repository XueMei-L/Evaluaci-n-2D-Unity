using UnityEngine;

public class BoxManager : MonoBehaviour
{
    void OnEnable()
    {
        GameEvents.OnChestOpened.AddListener(EndGame);
    }

    void OnDisable()
    {
        GameEvents.OnChestOpened.RemoveListener(EndGame);
    }

    void EndGame()
    {
        Time.timeScale = 0f; // Pausa el juego
    }
}
