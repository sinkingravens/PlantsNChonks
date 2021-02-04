using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionZone : MonoBehaviour
{
    GameObject minions;
    // Start is called before the first frame update
    void Start()
    {
        minions = GameObject.FindGameObjectWithTag("Minion");
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Minions are in their safe zone, and will follow the enemy if its inside it
        minions.GetComponent<Minions>().safeZone = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Minions arent in their safezone and will stop following the player.
        minions.GetComponent<Minions>().safeZone = false;
    }
}
