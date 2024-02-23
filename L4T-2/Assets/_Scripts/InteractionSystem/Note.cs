using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Note : MonoBehaviour, IInteractable
{
    public GameObject hand;
    public GameObject noteUI;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            other.GetComponent<Inventory>().InteractableObject = this;
            hand.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            other.GetComponent<Inventory>().InteractableObject = null;
            hand.SetActive(false);
            noteUI.SetActive(false);

        }
    }

    public void Interact()
    {
        noteUI.SetActive(!noteUI.activeInHierarchy);
    }
}
