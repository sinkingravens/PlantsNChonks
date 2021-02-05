using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour
{
    [Header("Ammunition, bullet speed etc")]
    public KeyCode shootKey = KeyCode.Space;
    public GameObject ammo;
    public float ammoSpeed = 30f;
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        //if shootkey is down, instantiate ammo.
        if (Input.GetKeyDown(shootKey))
        {
            Debug.Log("shot");
            GameObject shot = GameObject.Instantiate(ammo, transform.position, transform.rotation);
            //If isUp is true, then the bullets will shoot up
            if(player.GetComponent<PlayerController>().isUp)
            {
                shot.GetComponent<Rigidbody2D>().velocity = transform.up * ammoSpeed;
            }
            // else itll shoot down
            else if(player.GetComponent<PlayerController>().isDown)
            {
                shot.GetComponent<Rigidbody2D>().velocity = -transform.up * ammoSpeed;
            }
            //if isLeft is true then itll shoot to the left
            else if(player.GetComponent<PlayerController>().isLeft)
            {
                shot.GetComponent<Rigidbody2D>().velocity = (-transform.right * ammoSpeed);
            }
            //else itll shoot to the right
            else if (!player.GetComponent<PlayerController>().isLeft)
            {
                shot.GetComponent<Rigidbody2D>().velocity = (transform.right * ammoSpeed);
            }
        }
    }
}
