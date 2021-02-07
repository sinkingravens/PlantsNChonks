using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionsEnemySpotted : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if a player is nearby in its sight, then enemy spotted is true
        if (collision.CompareTag("Player"))
        {
            gameObject.GetComponentInParent<Minions>().enemySpotted = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //if it leaves out of the minions sight, its false
        if (collision.CompareTag("Player"))
        {
            gameObject.GetComponentInParent<Minions>().enemySpotted = false;
        }
    }
}
