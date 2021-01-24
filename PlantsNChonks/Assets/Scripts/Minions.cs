using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minions : MonoBehaviour
{
    public Transform Player;
    public float speed = 3f;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 displacement = Player.position - transform.position;
        displacement = displacement.normalized;

        if (Vector2.Distance(Player.position, transform.position) > 2.0f)
        {
            transform.position += (displacement * speed * Time.deltaTime);
        }
    }
}
