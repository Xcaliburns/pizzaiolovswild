using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UpdateScore : MonoBehaviour

{

    PlayerController player;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pizza"))
        {
            player.score += score;
            Debug.Log(player.score);
        }
    }
}
