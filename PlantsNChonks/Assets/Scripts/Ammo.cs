using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    void Start()
    {
          Destroy(gameObject, 3);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if ammo collides with enemy, destroy this.
        if (collision.gameObject.CompareTag("Minion"))
        {
            GameObject.Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
