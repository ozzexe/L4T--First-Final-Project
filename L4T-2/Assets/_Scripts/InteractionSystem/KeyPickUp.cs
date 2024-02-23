using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTutorial.Manager;

public class KeyPickUp : MonoBehaviour, IInteractable
{
    // Start is called before the first frame update
    public GameObject keyimage;
    public GameObject keyistrue;
    public GameObject hand;
    public bool isplayer;
    
    void Start()
    {
        isplayer = false;
        


    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {

            other.GetComponent<Inventory>().InteractableObject = this;
            hand.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

            other.GetComponent<Inventory>().InteractableObject = null;
            hand.SetActive(false);

        }
    }

    // Update is called once per frame
    public void Interact ()
    {
        keyimage.SetActive(true);
        keyistrue.SetActive(true);
        hand.SetActive(false);
        Destroy(gameObject);
    }
}
