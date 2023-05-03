using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float delayTime = 0.5f;
    private bool inputEnabled = true;


    IEnumerator DelayInput()
    {
        inputEnabled = false; 
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        yield return new WaitForSeconds(delayTime); // wait for the specified amount of time
        inputEnabled = true; // enable input

       
        
    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (inputEnabled && Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(DelayInput());
        }
    }
}
