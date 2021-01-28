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

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        minions.GetComponent<Minions>().safeZone = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        minions.GetComponent<Minions>().safeZone = false;
    }
}
