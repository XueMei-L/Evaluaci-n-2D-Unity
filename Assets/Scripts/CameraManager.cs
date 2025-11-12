using UnityEngine;
using Unity.Cinemachine;

public class CameraController : MonoBehaviour
{
    public CinemachineCamera mainCam;   // cámara que sigue al jugador
    public CinemachineCamera wideCam;   // cámara amplia

    void Start()
    {
        mainCam.gameObject.SetActive(true);
        wideCam.gameObject.SetActive(false);
    }

    void Update()
    {
        // Cambiar de cámara con tecla C
        if (Input.GetKeyDown(KeyCode.C))
        {
            bool mainActive = mainCam.gameObject.activeSelf;
            mainCam.gameObject.SetActive(!mainActive);
            wideCam.gameObject.SetActive(mainActive);
        }
    }
}
