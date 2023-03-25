using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public DynamicJoystick moveStick;
    public float moveSpeed;

    Rigidbody2D rb;
    Animator anim;
    Vector3 moveDir;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float axisX = moveStick.Horizontal;
        float axisY = moveStick.Vertical;

        moveDir = new Vector2(axisX, axisY);

        if(moveDir.x == 0 && moveDir.y == 0)
        {
            anim.SetFloat("RunState", 0f);
        }

        if(moveDir.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
        anim.SetFloat("RunState", 0.5f);
    }
}
