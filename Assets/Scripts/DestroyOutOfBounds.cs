using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBound = 30.0f;
    public float lowBound = -10.0f;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < lowBound)
        {
            Debug.Log("Game Over !!!");
            Destroy(gameObject);
        }
    }
}
