using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTutorial.Manager;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject inventoryimage;
    public IInteractable InteractableObject;
    bool istrue;
    private InputManager inputManager;
    void Start()
    {
        inputManager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputManager.Interact && InteractableObject != null)
        {
            InteractableObject.Interact();
            InteractableObject = null;
        }

        inventoryimage.SetActive(inputManager.Inventory);
    }
}
