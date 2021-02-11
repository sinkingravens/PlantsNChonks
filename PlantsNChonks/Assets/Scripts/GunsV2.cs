using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsV2 : MonoBehaviour
{
    GameObject bullet;
    Transform cursor;
    public float bulletSpeed = 30f;

    Vector2 cursorDirection;
    float cursorAngle;

    private void Update()
    {
        cursorDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursorAngle = Mathf.Atan2(cursorDirection.y, cursorDirection.x) * Mathf.Rad2Deg;

        //cursor.rotation = Quaternion.Euler
    }


}
