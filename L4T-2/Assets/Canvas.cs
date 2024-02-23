using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Countdown");

    }

    private IEnumerator Countdown()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);


    }

}