using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerV2 : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 3f;
    public Rigidbody2D rb;
    private Vector2 position;

    void Start()
    {
        
    }

    void Update()
    {
        ProcessInput();   
    }

    void FixedUpdate()
    {
        Movement();
    }

    void ProcessInput()
    {
        //Processes the input
        position.x = Input.GetAxisRaw("Horizontal");
        position.y = Input.GetAxisRaw("Vertical");

        //Makes sure when you walk between horizontal & vertical that its the same speed
        position = new Vector2(position.x, position.y).normalized;

    }

    void Movement()
    {
        //Movement is in FixedUpdate because otherwise it would depend on framerates which would could potentially change movement
        rb.velocity = new Vector2(position.x * moveSpeed, position.y * moveSpeed);
    }
}
