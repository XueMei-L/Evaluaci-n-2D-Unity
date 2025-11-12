using UnityEngine;
using UnityEngine.Events;

public class GameEvents : MonoBehaviour
{
    // Evento que se dispara cuando se abre un cofre
    public static UnityEvent OnChestOpened = new UnityEvent();
}
