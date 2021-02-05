using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public KeyCode jumpKey = KeyCode.W;
    public float speed = 3.0f;
    public float jumpHeight = 300f;

    [Header("Health")]
    public float health = 100f;

    [Header("Misc")]
    public bool isLeft;
    public bool isUp = false;
    public bool isDown;

    private void Start()
    {

    }

    private void Update()
    {
        Movement();
    }

    public void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        transform.position = position;

        //if Horizontal is less than 0, then the character will inverted so it looks left.
        if (horizontal < 0)
        {
            transform.localScale = new Vector3(1, 1, 0);
            isLeft = true;
            isUp = false;

        }
        //if horizontal is more than 0, then the character will stay in its current position (looking right).
        else if (horizontal > 0)
        {
            transform.localScale = new Vector3(-1, 1, 0);
            isLeft = false;
            isUp = false;
            isDown = false;
        }
        //if vertical is less than 0, then the character is looking down
        else if(vertical < 0)
        {
            isDown = true;
            isUp = false;
            isLeft = false;
        }
        //if vertical is more than 0, then the character is looking up;
        else if(vertical > 0)
        {
            isUp = true;
            isLeft = false;
            isDown = false;
        }
    }

}
