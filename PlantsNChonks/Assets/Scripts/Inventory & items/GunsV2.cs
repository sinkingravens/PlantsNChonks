using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsV2 : MonoBehaviour
{

    [Header("Key Mechanics")]
    public KeyCode useKey = KeyCode.E;
    public float bulletSpeed = 30f;


    public GameObject bullet;
    public Transform firePoint;

    Vector2 cursorDirection;
    float cursorAngle;

    private void Update()
    {
        InputProcess();
        RotationProcess();
        Shooting();
    }
    void InputProcess()
    {
        //Cursor being calculated where it is on the screen
        cursorDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursorAngle = Mathf.Atan2(cursorDirection.y, cursorDirection.x) * Mathf.Rad2Deg;
        //Rotates the firepoint so it can shoot the correct way.
        firePoint.rotation = Quaternion.Euler(0, 0, cursorAngle);
    }

    void Shooting()
    {
        //if shootKey is pressed, the bullet goes pew pew towards cursorAngle.
        if (Input.GetKeyDown(useKey))
        {
            GameObject bulletGoesPewPew = Instantiate(bullet);
            bulletGoesPewPew.transform.position = firePoint.position;
            bulletGoesPewPew.transform.rotation = Quaternion.Euler(0, 0, cursorAngle);

            bulletGoesPewPew.GetComponent<Rigidbody2D>().velocity = firePoint.right * bulletSpeed;
            Debug.Log("" + cursorAngle + "");
        }
    }

    void RotationProcess()
    {
        this.transform.rotation = Quaternion.Euler(0, 0, cursorAngle);
    }

}
