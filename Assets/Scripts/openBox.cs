using UnityEngine;
using TMPro;

public class Chest : MonoBehaviour
{
    private Animator anim;
    private bool isOpened = false;

    public TMP_Text winText; // referencia al texto en pantalla

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isOpened)
        {
            isOpened = true;

            // Reproduce la animación de abrir
            anim.SetTrigger("OpenTrigger");

            // Mostrar texto de victoria
            winText.gameObject.SetActive(true);

            // 🔔 Disparar el evento
            GameEvents.OnChestOpened.Invoke();
        }
    }
}
