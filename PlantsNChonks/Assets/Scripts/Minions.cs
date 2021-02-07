using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minions : MonoBehaviour
{
    [Header("Movement")]
    GameObject player;
    public Transform playerPosition;
    public float speed = 3f;

    [Header("Zoning")]
    public bool enemySpotted = true;

    [Header("Health & Damage")]
    public float health = 100f;
    public float damage = 0f;

    void Start()
    {
        //finds the player that it'll chase
        player = GameObject.FindGameObjectWithTag("Player");
        playerPosition = player.transform;
    }

    void Update()
    {
        FollowPlayer();
    }

    public void FollowPlayer()
    {
        Vector3 distance = playerPosition.position - transform.position;
        distance = distance.normalized;
        //if the distance is greater than 2 and the minion has spotted an enemy, then follow that player"
        if (Vector2.Distance(playerPosition.position, transform.position) > 1.0f && enemySpotted == true)
        {
            transform.position += (distance * speed * Time.deltaTime);
        }
    }

}
