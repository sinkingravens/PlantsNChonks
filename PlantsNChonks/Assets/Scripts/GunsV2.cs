using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsV2 : MonoBehaviour
{

    [Header("Key Mechanics")]
    public KeyCode shootKey = KeyCode.E;
    public float bulletSpeed = 30f;

    public GameObject bullet;
    public Transform firePoint;

    Vector2 cursorDirection;
    float cursorAngle;

    private void Update()
    {
        InputProcess();
    }

    void InputProcess()
    {
        cursorDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursorAngle = Mathf.Atan2(cursorDirection.y, cursorDirection.x) * Mathf.Rad2Deg;

        firePoint.rotation = Quaternion.Euler(0, 0, cursorAngle);
        if(Input.GetKeyDown(shootKey))
        {
            GameObject bulletGoesPewPew = Instantiate(bullet);
            bulletGoesPewPew.transform.position = firePoint.position;
            bulletGoesPewPew.transform.rotation = Quaternion.Euler(0, 0, cursorAngle);

            bulletGoesPewPew.GetComponent<Rigidbody2D>().velocity = firePoint.right * bulletSpeed; 
        }
    }


}
