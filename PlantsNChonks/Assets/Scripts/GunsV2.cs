using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsV2 : MonoBehaviour
{
    public KeyCode shootKey = KeyCode.Space;

    [Header("Fire towards cursor, bullet and their speed")]
    public GameObject bullet;
    public Transform fireTowards;
    public float bulletSpeed = 30f;

    [Header("Calculation for cursor to player")]
    Vector2 lookDirection;
    float lookAngle;

    void Start()
    {
        
    }


    void Update()
    {
        shootCursor();
    }

    void shootCursor()
    {
        //Does the math to calculate the angle from where the cursor is to the player.
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        fireTowards.rotation = Quaternion.Euler(0, 0, lookAngle);

        if(Input.GetKeyDown(shootKey))
        {
            GameObject bulletShot = Instantiate(bullet);
            bulletShot.transform.position = fireTowards.position;
            bulletShot.transform.rotation = Quaternion.Euler(0, 0, lookAngle);

            bulletShot.GetComponent<Rigidbody2D>().velocity = fireTowards.right * bulletSpeed;
        }

    }
}
