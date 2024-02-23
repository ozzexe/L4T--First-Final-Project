using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
    Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        // Yeni Input System'u kullanarak Z tuþunu kontrol et
        if (Keyboard.current[Key.E].wasPressedThisFrame)
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}