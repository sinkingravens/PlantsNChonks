using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scythe : MonoBehaviour
{
    public bool active;
    private GameObject hand;

    void Start()
    {
        hand = GameObject.FindWithTag("Hand"); //find the gameobject tagged hand 
        hand.GetComponent<Inventory>().activeScythe = true; //set the bool to true when holdin scythe;
    }

}
