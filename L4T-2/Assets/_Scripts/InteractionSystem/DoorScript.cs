using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTutorial.Manager;

public class DoorScript : MonoBehaviour, IInteractable
{
    // Start is called before the first frame update
    public GameObject hand;
    public GameObject keyistrue;
    public bool isplayer;
    public AudioClip doorOpen;
    Animator animator;
    private object hit;

    void Start()
    {
        animator = GetComponent<Animator>();


    }

    void OnTriggerEnter(Collider other)
    {       
        if (other.tag == "Player")
        {
            hand.SetActive(true);
            other.GetComponent<Inventory>().InteractableObject = this;           
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            hand.SetActive(false);
            other.GetComponent<Inventory>().InteractableObject = null;       
        }
    }

    public void Interact()
    {
        hand.SetActive(false);
        animator.enabled = true;              
    }
}
